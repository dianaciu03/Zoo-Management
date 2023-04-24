using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccess.AnimalInterfaces;

namespace DataAccess.AnimalRepositories
{
    public class AnimalRepository : IAnimalRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public List<AnimalDTO> GetAllAnimals(string sortBy) // Gets all animals in the animal database and returns them as a list of Animal Objects
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }

                SqlCommand query = new SqlCommand($"SELECT * FROM Animals ORDER BY {sortBy} ASC", connection);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AnimalDTO animal = new AnimalDTO(
                                    reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetString(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("Species")),
                                    reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    reader.GetString(reader.GetOrdinal("Origin")),
                                    reader.GetString(reader.GetOrdinal("Description")),
                                    reader.GetString(reader.GetOrdinal("Endangerment")),
                                    reader.GetInt32(reader.GetOrdinal("Enclosure")),
                                    reader.GetString(reader.GetOrdinal("Availability")));

                        animals.Add(animal);
                    }
                    reader.Close();
                    connection.Close();
                    return animals;
                }
            }
        }

        public void AddUpdateAnimal(AnimalDTO animal) //Opens connection and checks if the animal provided already exists in the database.
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try
                {
                    connection.Open();


                    SqlCommand existsInDatabase = new SqlCommand($"SELECT AnimalID FROM Animals WHERE AnimalID = {animal.Id}", connection);
                    int existsInDB = Convert.ToInt32(existsInDatabase.ExecuteScalar());
                    if (existsInDB > 0)
                    {
                        UpdateAnimal(animal, connection);
                    }
                    else
                    {
                        AddNewAnimal(animal, connection);
                    }
                }
                catch (SqlException) { }

                connection.Close();
            }
        }

        private void AddNewAnimal(AnimalDTO animal, SqlConnection connection) //Inserts the new Animal into the database.
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Animals " +
                                                       "VALUES (@Name,@Gender,@Species,@BirthDate,@Origin,@Description,@Endangerment,@Enclosure,@Availability)",
                                                       connection))
            {
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Gender", animal.Gender);
                command.Parameters.AddWithValue("@Species", animal.Species);
                command.Parameters.AddWithValue("@BirthDate", animal.Birthday);
                command.Parameters.AddWithValue("@Origin", animal.OriginContinent.ToString());
                command.Parameters.AddWithValue("@Description", animal.Description);
                command.Parameters.AddWithValue("@Endangerment", animal.Endangerment.ToString());
                command.Parameters.AddWithValue("@Enclosure", animal.Enclosure);
                command.Parameters.AddWithValue("@Availability", animal.Availability);

                command.ExecuteNonQuery();
            }
        }

        private void UpdateAnimal(AnimalDTO animal, SqlConnection connection) //Updates and already existing animal from the database
        {
            using (SqlCommand command = new SqlCommand("UPDATE Animals " +
                                                       "SET Name = @Name, Gender = @Gender, Species = @Species, BirthDate = @BirthDate," +
                                                       "Origin = @Origin, Description = @Description, Endangerment = @Endangerment, Enclosure = @Enclosure, Availability = @Availability " +
                                                       "WHERE AnimalID = @AnimalID", connection))
            {
                command.Parameters.AddWithValue("@AnimalID", animal.Id);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Gender", animal.Gender);
                command.Parameters.AddWithValue("@Species", animal.Species);
                command.Parameters.AddWithValue("@BirthDate", animal.Birthday);
                command.Parameters.AddWithValue("@Origin", animal.OriginContinent.ToString());
                command.Parameters.AddWithValue("@Description", animal.Description);
                command.Parameters.AddWithValue("@Endangerment", animal.Endangerment.ToString());
                command.Parameters.AddWithValue("@Enclosure", animal.Enclosure);
                command.Parameters.AddWithValue("@Availability", animal.Availability);

                command.ExecuteNonQuery();
            }
        }

        public void ChangeAvailability(int animalID, string animalAvailability)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand command = new SqlCommand($"UPDATE Animals SET Availability = @Availability WHERE AnimalID = @AnimalID");

                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Availability", animalAvailability);
                    command.Parameters.AddWithValue("@AnimalID", animalID);
                    command.ExecuteNonQuery();

                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<AnimalDTO> SearchForAnimals(string name, string species, string origin, string gender, int? age, string endangerment, string availability)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();



            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }


                //Dynamic SQL query to find the festivals that the user is searching for.
                SqlCommand query = new SqlCommand("SELECT * FROM Animals WHERE " +
                    "(Name LIKE '%' + @Name + '%') AND " +
                    "(Species LIKE '%' + @Species + '%') AND " +
                    "(Origin = @Origin OR @Origin = '')  AND " +
                    "(Gender = @Gender OR @Gender = '') AND " +
                    "((BirthDate > @birthDateOneYear AND BirthDate < @birthDate) OR @birthDate is NULL ) AND " +
                    "(Endangerment = @Endangerment OR @Endangerment = '') AND " +
                    "(Availability = @Availability OR @Availability = '') " +
                    "ORDER BY Name;", connection);

                query.Parameters.AddWithValue("@Name", name);
                query.Parameters.AddWithValue("@Species", species);
                query.Parameters.AddWithValue("@Origin", origin);
                query.Parameters.AddWithValue("@Gender", gender);
                query.Parameters.AddWithValue("@Endangerment", endangerment);
                query.Parameters.AddWithValue("@Availability", availability);

                if (age != null)
                {
                    query.Parameters.AddWithValue("@birthDateOneYear", DateTime.Today.AddYears(-Convert.ToInt32(age) - 1));
                    query.Parameters.AddWithValue("@birthDate", DateTime.Today.AddYears(-Convert.ToInt32(age)));
                }
                else
                {
                    query.Parameters.AddWithValue("@birthDateOneYear", DBNull.Value);
                    query.Parameters.AddWithValue("@birthDate", DBNull.Value);
                }

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AnimalDTO animal = new AnimalDTO(
                            reader.GetInt32(reader.GetOrdinal("AnimalID")),
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetString(reader.GetOrdinal("Gender")),
                            reader.GetString(reader.GetOrdinal("Species")),
                            reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                            reader.GetString(reader.GetOrdinal("Origin")),
                            reader.GetString(reader.GetOrdinal("Description")),
                            reader.GetString(reader.GetOrdinal("Endangerment")),
                            reader.GetInt32(reader.GetOrdinal("Enclosure")),
                            reader.GetString(reader.GetOrdinal("Availability")));

                        animals.Add(animal);
                    }
                    reader.Close();
                    connection.Close();
                    return animals;
                }
            }
        }

        public void AddParentChildRelationship(int animalIDParent, int animalIDChild)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand command = new SqlCommand($"INSERT INTO AnimalRelationships " +
                    $"VALUES(1, @AnimalIDParent, @AnimalIDChild)", connection);

                command.Parameters.AddWithValue("@AnimalIDParent", animalIDParent);
                command.Parameters.AddWithValue("@AnimalIDChild", animalIDChild);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void AddMateRelationship(int animalIDMale, int animalIDFemale)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand command = new SqlCommand($"INSERT INTO AnimalRelationships " +
                    $"VALUES(0, @AnimalIDMale, @AnimalIDFemale)", connection);

                command.Parameters.AddWithValue("@AnimalIDMale", animalIDMale);
                command.Parameters.AddWithValue("@AnimalIDFemale", animalIDFemale);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<AnimalDTO> GetChildren(int animalID)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {


                SqlCommand query = new SqlCommand("SELECT Animals.* FROM AnimalRelationships " +
                    "INNER JOIN Animals ON Animals.AnimalID = AnimalRelationships.AnimalTwoID " +
                    "WHERE AnimalOneID = @AnimalOneID AND RelationshipType = 1;", connection);

                query.Parameters.AddWithValue("@AnimalOneID", animalID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalDTO animal = new AnimalDTO(
                                reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("Gender")),
                                reader.GetString(reader.GetOrdinal("Species")),
                                reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader.GetString(reader.GetOrdinal("Origin")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Endangerment")),
                                reader.GetInt32(reader.GetOrdinal("Enclosure")),
                                reader.GetString(reader.GetOrdinal("Availability")));

                            animals.Add(animal);
                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }

                return animals;
            }
        }

        public List<AnimalDTO> GetParents(int animalID)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT Animals.* FROM AnimalRelationships " +
                    "INNER JOIN Animals ON Animals.AnimalID = AnimalRelationships.AnimalOneID " +
                    "WHERE AnimalTwoID = @AnimalTwoID AND RelationshipType = 1;", connection);

                query.Parameters.AddWithValue("@AnimalTwoID", animalID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalDTO animal = new AnimalDTO(
                                reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("Gender")),
                                reader.GetString(reader.GetOrdinal("Species")),
                                reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                reader.GetString(reader.GetOrdinal("Origin")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Endangerment")),
                                reader.GetInt32(reader.GetOrdinal("Enclosure")),
                                reader.GetString(reader.GetOrdinal("Availability")));

                            animals.Add(animal);
                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }

                return animals;
            }
        }

        public List<AnimalDTO> GetMates(int animalID, string gender)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {

                SqlCommand query;
                if (gender == "Female")
                {
                    query = new SqlCommand("SELECT Animals.* FROM AnimalRelationships " +
                        "INNER JOIN Animals ON Animals.AnimalID = AnimalRelationships.AnimalOneID " +
                        "WHERE AnimalTwoID = @AnimalID AND RelationshipType = 0;", connection);

                }
                else
                {
                    query = new SqlCommand("SELECT Animals.* FROM AnimalRelationships " +
                        "INNER JOIN Animals ON Animals.AnimalID = AnimalRelationships.AnimalTwoID " +
                        "WHERE AnimalOneID = @AnimalID AND RelationshipType = 0;", connection);
                }
                query.Parameters.AddWithValue("@AnimalID", animalID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalDTO animal = new AnimalDTO(
                             reader.GetInt32(reader.GetOrdinal("AnimalID")),
                             reader.GetString(reader.GetOrdinal("Name")),
                             reader.GetString(reader.GetOrdinal("Gender")),
                             reader.GetString(reader.GetOrdinal("Species")),
                             reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                             reader.GetString(reader.GetOrdinal("Origin")),
                             reader.GetString(reader.GetOrdinal("Description")),
                             reader.GetString(reader.GetOrdinal("Endangerment")),
                             reader.GetInt32(reader.GetOrdinal("Enclosure")),
                             reader.GetString(reader.GetOrdinal("Availability")));

                            animals.Add(animal);

                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }

                return animals;
            }
        }

        public List<AnimalDTO> GetSiblings(int animalID)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            List<AnimalDTO> parents = GetParents(animalID);


            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {

                SqlCommand query;

                query = new SqlCommand("SELECT DISTINCT Animals.* FROM AnimalRelationships " +
                    "INNER JOIN Animals ON Animals.AnimalID = AnimalRelationships.AnimalTwoID " +
                    "WHERE (AnimalOneID = @ParentOneID OR AnimalOneID = @ParentTwoID) AND RelationshipType = 1" +
                    "AND AnimalTwoID != @AnimalID;", connection);

                if (parents.Count <= 0)
                {
                    return animals;
                }

                if (parents[0] != null)
                {
                    query.Parameters.AddWithValue("@ParentOneID", parents[0].Id);
                }
                if (parents[1] != null)
                {
                    query.Parameters.AddWithValue("@ParentTwoID", parents[1].Id);
                }
                else
                {
                    query.Parameters.AddWithValue("@ParentTwoID", "");
                }

                query.Parameters.AddWithValue("@AnimalID", animalID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalDTO animal = new AnimalDTO(
                             reader.GetInt32(reader.GetOrdinal("AnimalID")),
                             reader.GetString(reader.GetOrdinal("Name")),
                             reader.GetString(reader.GetOrdinal("Gender")),
                             reader.GetString(reader.GetOrdinal("Species")),
                             reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                             reader.GetString(reader.GetOrdinal("Origin")),
                             reader.GetString(reader.GetOrdinal("Description")),
                             reader.GetString(reader.GetOrdinal("Endangerment")),
                             reader.GetInt32(reader.GetOrdinal("Enclosure")),
                             reader.GetString(reader.GetOrdinal("Availability")));

                            animals.Add(animal);

                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }

                return animals;
            }
        }

        public List<AnimalDTO> OtherInSpeciesSearch(int animalID, string species)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }

                SqlCommand query = new SqlCommand("SELECT * FROM Animals " +
                    "WHERE Species = @Species AND AnimalID != @AnimalID;", connection);

                query.Parameters.AddWithValue("@Species", species);
                query.Parameters.AddWithValue("@AnimalID", animalID);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AnimalDTO animal = new AnimalDTO(
                                    reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetString(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("Species")),
                                    reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    reader.GetString(reader.GetOrdinal("Origin")),
                                    reader.GetString(reader.GetOrdinal("Description")),
                                    reader.GetString(reader.GetOrdinal("Endangerment")),
                                    reader.GetInt32(reader.GetOrdinal("Enclosure")),
                                    reader.GetString(reader.GetOrdinal("Availability")));

                        animals.Add(animal);
                    }

                    reader.Close();
                    connection.Close();
                    return animals;
                }
            }
        }



        //TODO remove function that changes its status

        //Transfer detail table

        //Relationship table
    }
}

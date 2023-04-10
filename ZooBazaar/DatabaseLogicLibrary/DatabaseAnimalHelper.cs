using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseLogicLibrary
{
    public class DatabaseAnimalHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public int NewAnimalID()
        {
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT MAX(AnimalID) FROM Animals", connection);

                try
                {
                    connection.Open();
                    if (query.ExecuteScalar() != DBNull.Value)
                    {
                        i = (Int32)query.ExecuteScalar();
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return i + 1; //+1 beacuse we need a new animal id so we get the current highest in database + 1
            }

        }

        public List<AnimalDTO> GetAllAnimals() // Gets all animals in the animal database and returns them as a list of Animal Objects
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }

                SqlCommand query = new SqlCommand("SELECT * FROM Animals", connection);

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
                try { connection.Open(); }
                catch (SqlException) { return; }

                SqlCommand existsInDatabase = new SqlCommand($"SELECT COUNT(*) FROM Animals WHERE AnimalID = {animal.Id}");
                if (existsInDatabase.ExecuteScalar() == DBNull.Value)
                {
                    UpdateAnimal(animal, connection);
                }
                else
                {
                    AddNewAnimal(animal, connection);
                }
                connection.Close();
            }
        }

        private void AddNewAnimal(AnimalDTO animal, SqlConnection connection) //Inserts the new Animal into the database.
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Animals" +
                                                       "VALUES (@AnimalID,@Name,@Gender,@Species,@BirthDate,@Origin,@Description,@Endangerment,@Enclosure, @Availability)", connection))
            {
                command.Parameters.AddWithValue("@AnimalID", animal.Id);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Gender", animal.Gender);
                command.Parameters.AddWithValue("@Speciecs", animal.Species);
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
                                                       "SET AnimalID = @AmimalID, Name = @Name, Gender = @Gender, Species = @Species, BirthDate = @BirthDate," +
                                                       "Origin = @Origin, Description = @Description, Endangerment = @Endangerment, Enclosure = @Enclosure, Availability = @Availability " +
                                                       "WHERE AnimalID = @AnmimalID", connection))
            {
                command.Parameters.AddWithValue("@AnimalID", animal.Id);
                command.Parameters.AddWithValue("@Name", animal.Name);
                command.Parameters.AddWithValue("@Gender", animal.Gender);
                command.Parameters.AddWithValue("@Speciecs", animal.Species);
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

        public List<AnimalDTO> SearchForAnimals(string name, string species, string origin, string gender, int age, string endangerment)
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();



            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }


                //Dynamic SQL query to find the festivals that the user is searching for.
                SqlCommand query = new SqlCommand("SELECT * FROM Animals WHERE " +
                    "(Name LIKE '%' + @Name ) AND" +
                    "(Species LIKE '%' @Species) AND" +
                    "(Origin = @Origin) AND" +
                    "(Gender = @Gender) AND" +
                    "((BirthDate > @birthDateOneYear AND BirthDate < @birthDate) OR @birthDate is NULL ) AND" +
                    "(Endangerment LIKE '%' @Endangerment)" +
                    "ORDER BY Name;", connection);

                query.Parameters.AddWithValue("@Name", name);
                query.Parameters.AddWithValue("@Species", species);
                query.Parameters.AddWithValue("@Origin", origin);
                query.Parameters.AddWithValue("@Gender", gender);
                query.Parameters.AddWithValue("@Endangerment", endangerment);

                if (age >= 0)
                {
                    query.Parameters.AddWithValue("@birthDateOneYear", DateTime.Today.AddYears(-age - 1));
                    query.Parameters.AddWithValue("@birthDate", DateTime.Today.AddYears(-age));
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
                    $"VALUES(True, @AnimalIDParent, @AnimalIDChild)");
                
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
                    $"VALUES(False, @AnimalIDMale, @AnimalIDFemale)");

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

        public List<int> GetChildren(int animalID)
        {
            List<int> animalIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {


                SqlCommand query = new SqlCommand("SELECT AnimalTwoID FROM AnimalRelationships WHERE " +
                    "AnimalOneID = @AnimalOneID AND RelationshipType = True;", connection);

                    query.Parameters.AddWithValue("@AnimalOneID", animalID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            animalIDs.Add(reader.GetInt32(reader.GetOrdinal("AnimalTwoID")));
                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }
                
                return animalIDs;
            }
        }

        public List<int> GetParents(int animalID)
        {
            List<int> animalIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT AnimalOneID FROM AnimalRelationships WHERE " +
                    "AnimalTwoID = @AnimalTwoID AND RelationshipType = False;", connection);

                query.Parameters.AddWithValue("@AnimalTwoID", animalID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            animalIDs.Add(reader.GetInt32(reader.GetOrdinal("AnimalOneID")));
                        }
                        reader.Close();
                    }

                }
                catch (SqlException) { }
                finally { connection.Close(); }

                return animalIDs;
            }
        }

        public List<int> GetMates(int animalID)
        {
            //Get Mates
            throw new NotImplementedException();
        }



        //TODO remove function that changes its status

        //Transfer detail table

        //Relationship table
    }
}

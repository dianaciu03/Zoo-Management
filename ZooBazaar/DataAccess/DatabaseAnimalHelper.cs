using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DatabaseAnimalHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

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
                    while(reader.Read()) 
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
                catch(SqlException) { return; }

                SqlCommand existsInDatabase = new SqlCommand($"SELECT COUNT(*) FROM Animals WHERE AnimalID = {animal.Id}");
                if( (int)existsInDatabase.ExecuteScalar() > 0)
                {
                    UpdateAnimal( animal, connection );
                }
                else
                {
                    AddNewAnimal( animal, connection );
                }
                connection.Close();
            }
        }
        
        private void AddNewAnimal(AnimalDTO animal , SqlConnection connection) //Inserts the new Animal into the database.
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

        public int? GetAnimalCount() //Get count of how many animals total are in the database
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return null; }

                SqlCommand command = new SqlCommand("SELECT COUNT(AnimalID) FROM Animals");
                count = (Int32)command.ExecuteScalar();
            }
            return count;
        }

        public void ChangeAvailability(int animalID, string animalAvailability)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return; }

                SqlCommand command = new SqlCommand($"UPDATE Animals SET Availability = { animalAvailability } WHERE AnimalID = { animalID }");
                command.ExecuteNonQuery();
            }
        }



        //TODO remove function that changes its status

        //Transfer detail table

        //Relationship table

        //TODO Add search functionality.
/*        public List<Animal> SearchAnimals(string Species)
        {

        }*/

        //Employee
            //Get all
            //Add/Update
            //Get by role
            //Get employee count
    }
}

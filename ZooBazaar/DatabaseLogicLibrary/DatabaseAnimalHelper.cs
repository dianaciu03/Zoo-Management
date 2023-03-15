using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary;

namespace DatabaseLogicLibrary
{
    public class DatabaseAnimalHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public List<Animal> GetAllAnimals() // Gets all animals in the animal database and returns them as a list of Animal Objects
        {
            List<Animal> animals = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }

                SqlCommand query = new SqlCommand("SELECT * FROM Animals", connection);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (!reader.Read()) 
                    {
                        reader.Close();
                        connection.Close();
                        return animals; 
                    }

                    Animal animal = new Animal(reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                                reader.GetString(reader.GetOrdinal("Name")),
                                                reader.GetString(reader.GetOrdinal("Gender")),
                                                reader.GetString(reader.GetOrdinal("Species")),
                                                reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                                (ORIGINCONTINENT)Enum.Parse(typeof(ORIGINCONTINENT), reader.GetString(reader.GetOrdinal("Origin"))),
                                                reader.GetString(reader.GetOrdinal("Description")),
                                                (ENDANGERMENT)Enum.Parse(typeof(ENDANGERMENT), reader.GetString(reader.GetOrdinal("Endangerment"))),
                                                reader.GetInt32(reader.GetOrdinal("Enclosure")));
                    animals.Add(animal);
                }
            }
           return animals;
        }

        public void AddUpdateAnimal(Animal animal)
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

        private void AddNewAnimal( Animal animal , SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Animals" +
                                                       "VALUES (@AnimalID,@Name,Gender,@Species,@BirthDate,@Origin,@Description,@Endangerment,@Enclosure)", connection))
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

                command.ExecuteNonQuery();
            }
        }

        private void UpdateAnimal( Animal animal, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Animals " +
                                                       "SET AnimalID = @AmimalID, Name = @Name, Gender = @Gender, Species = @Species, BirthDate = @BirthDate," +
                                                       "Origin = @Origin, Description = @Description, Endangerment = @Endangerment, Enclosure = @Enclosure) " +
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

                command.ExecuteNonQuery();
            }
        }

        public List<Animal> SearchAnimals(string Species)
        {

        }
    }
}

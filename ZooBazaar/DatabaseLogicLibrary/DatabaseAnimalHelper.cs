using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary;
using ZooBazaarLogicLibrary.Enums;

namespace DatabaseLogicLibrary
{
    public class DatabaseAnimalHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return animals; }
                
                using (SqlCommand query = new SqlCommand("SELECT * FROM Animals", connection))
                {
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        if (!reader.Read()) 
                        {
                            connection.Close();
                            return animals; 
                        }

                        Animal animal = new Animal(reader.GetInt32(reader.GetOrdinal("AnimalID")),
                                                   reader.GetString(reader.GetOrdinal("Name")),
                                                   )
                    }
                }
            }
        }
    }
}

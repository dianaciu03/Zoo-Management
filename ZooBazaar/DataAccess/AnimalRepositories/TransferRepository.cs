using DataAccess.AnimalInterfaces;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.AnimalRepositories
{
    public class TransferRepository : ITransferRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public void AddNewTransfer(TransferDTO transfer)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return; }

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query = @"INSERT INTO Transfer (ZooName, ZooAddress, ZooPhone, Description, StartDate, EndDate, AnimalId) VALUES (@ZooName, @ZooAddress, @ZooPhone, @Description, @StartDate, @EndDate, @AnimalId)";
                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ZooName", transfer.ZooName);
                        command.Parameters.AddWithValue("@ZooAddress", transfer.ZooAddress);
                        command.Parameters.AddWithValue("@ZooPhone", transfer.ZooPhone);
                        command.Parameters.AddWithValue("@Description", transfer.Description);
                        command.Parameters.AddWithValue("@StartDate", transfer.StartDate);
                        command.Parameters.AddWithValue("@EndDate", transfer.EndDate);
                        command.Parameters.AddWithValue("@AnimalId", transfer.Animal.Id);

                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Transfer couldn't be added: {ex.Message}");
                }
                connection.Close();
            }
        }

        public List<TransferDTO> GetTransferByAnimalId(int id)
        {
            List<TransferDTO> transfersDTO = new List<TransferDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionHelper.ConnectionValue()))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Transfer INNER JOIN Animals ON Transfer.AnimalId = Animals.AnimalID WHERE Transfer.AnimalId=@AnimalId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@AnimalId", id);
                        SqlDataReader reader = command.ExecuteReader();

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

                            TransferDTO transfer = new TransferDTO(
                            reader.GetInt32(reader.GetOrdinal("TransferId")),
                            reader.GetString(reader.GetOrdinal("ZooName")),
                            reader.GetString(reader.GetOrdinal("ZooAddress")),
                            reader.GetString(reader.GetOrdinal("Description")),
                            reader.GetDateTime(reader.GetOrdinal("StartDate")),
                            reader.GetDateTime(reader.GetOrdinal("EndDate")),
                            reader.GetString(reader.GetOrdinal("ZooPhone")),
                            animal);

                            transfersDTO.Add(transfer);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (SqlException)
            {
                return transfersDTO;
            }
            catch (Exception)
            {
                throw new Exception("There were issues while trying to retrieve the anime!");
            }
            return transfersDTO;
        }
    }
}

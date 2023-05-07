using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EmployeeRepositories
{
    public class EmergencyContractRepository : IEmergencyContactRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public EmergencyContractRepository() { }

        public EmergencyContactDTO GetEmergencyContactByID(int id)
        {
            EmergencyContactDTO contactDTO;
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM dbo.EmergencyContacts Where EmployeeID = @id", connection);
                query.Parameters.AddWithValue("id", id);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    try
                    {
                        reader.Read();
                        contactDTO = new EmergencyContactDTO()
                        {
                            firstName = reader.GetString(reader.GetOrdinal("ContactFirstName")),
                            lastName = reader.GetString(reader.GetOrdinal("ContactLastName")),
                            relationship = reader.GetString(reader.GetOrdinal("Relationship")),
                            phone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            employeeId = (int)reader.GetSqlInt32(reader.GetOrdinal("EmployeeID"))
                        };
                        reader.Close();
                        connection.Close();
                        return contactDTO;
                    }
                    catch
                    {
                        return new EmergencyContactDTO();
                    }
                }
            }
        }

        public void UpdateEmergencyContact(EmergencyContactDTO emergencyContact)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                {
                    connection.Open();
                    SqlCommand command;
                    command = new SqlCommand("UPDATE dbo.EmergencyContacts SET ContactFirstName=@firstName ,ContactLastName=@lastName,Relationship=@relationship,ContactPhone=@phone WHERE EmployeeID = @employeeID", connection);
                    using (command)
                    {
                        command.Parameters.AddWithValue("@employeeID", emergencyContact.employeeId);
                        command.Parameters.AddWithValue("@firstName", emergencyContact.firstName);
                        command.Parameters.AddWithValue("@lastName", emergencyContact.lastName);
                        command.Parameters.AddWithValue("@relationship", emergencyContact.relationship);
                        command.Parameters.AddWithValue("@phone", emergencyContact.phone);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
        }
    }
}

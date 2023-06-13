using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tickets
{
    public class TicketRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public void AddTicket(TicketDTO ticket)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("INSERT INTO Tickets " +
                    "(TicketType, TicketPrice, ValidDate, BarcodeString)" +
                    "VALUES(@TicketType, @TicketPrice, @ValidDate, @BarcodeString", connection);

                query.Parameters.AddWithValue("@TicketType", ticket.TicketType);
                query.Parameters.AddWithValue("@TicketPrice", ticket.TicketPrice);
                query.Parameters.AddWithValue("@ValidDate", ticket.ValidDate);
                query.Parameters.AddWithValue("@BarcodeString", ticket.Barcode);

                try
                {
                    connection.Open();
                    query.ExecuteNonQuery();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }

            }
        }

        public bool IsValid(string barcode, DateTime date)
        {
            bool ticketIsValid  = false;

            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Tickets " +
                    "WHERE BarcodeString = @BarcodeString AND " +
                    "ValidDate = @ValidDate", connection);

                query.Parameters.AddWithValue("@ValidDate", date);
                query.Parameters.AddWithValue("@BarcodeString", barcode);

                try
                {
                    connection.Open();
                    if(Convert.ToInt32(query.ExecuteScalar()) > 0)
                    {
                        ticketIsValid = true;
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }

            }

            return ticketIsValid;
        }

        public TicketDTO GetTicket(string barcode)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());

            TicketDTO ticket = null;

            using (connection)
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Tickets " +
                    "WHERE BarcodeString = @BarcodeString", connection);

                query.Parameters.AddWithValue("@Barcode", barcode);

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = query.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ticket = new(
                                reader.GetInt32(reader.GetOrdinal("TicketID")),
                                reader.GetString(reader.GetOrdinal("TicketType")),
                                reader.GetDecimal(reader.GetOrdinal("TicketPrice")),
                                reader.GetDateTime(reader.GetOrdinal("ValidDate")),
                                reader.GetString(reader.GetOrdinal("BarcodeString")));
                        }
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }

            }
            return ticket;
        }
    }
}

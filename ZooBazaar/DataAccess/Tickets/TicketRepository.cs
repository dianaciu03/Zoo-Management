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

        public TicketDTO AddTicket(TicketDTO ticket)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand newNumber = new SqlCommand("SELECT MAX(BarcodeString) FROM Tickets " +
                    "WHERE BarcodeString < @NextDateString " +
                    "AND BarcodeString > @CurrentDayString", connection);

                decimal currentDate = Convert.ToDecimal($"{ticket.ValidDate.Date}00000");
                decimal nextDate = Convert.ToDecimal($"{ticket.ValidDate.AddDays(1).Date}00000");
                newNumber.Parameters.AddWithValue("@NextDateString", nextDate);
                newNumber.Parameters.AddWithValue("@NextDateString", nextDate);


                decimal currentHighest = 0;
                try
                {
                    connection.Open();
                    if (Convert.ToDecimal(newNumber.ExecuteScalar()) > 0){
                        currentHighest = Convert.ToDecimal(newNumber.ExecuteScalar());
                    }
                    else
                    {
                        currentHighest = currentDate;
                    }
                }
                catch (SqlException) { }

                SqlCommand query = new SqlCommand("INSERT INTO Tickets " +
                    "(TicketType, TicketPrice, ValidDate, BarcodeString)" +
                    "VALUES(@TicketType, @TicketPrice, @ValidDate, @BarcodeString", connection);

                query.Parameters.AddWithValue("@TicketType", ticket.TicketType);
                query.Parameters.AddWithValue("@TicketPrice", ticket.TicketPrice);
                query.Parameters.AddWithValue("@ValidDate", ticket.ValidDate);
                query.Parameters.AddWithValue("@BarcodeString", currentHighest+1);

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
                return new TicketDTO(
                    ticket.TicketType,
                    ticket.TicketPrice,
                    ticket.ValidDate,
                    currentHighest+1
                    );

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
                                reader.GetString(reader.GetOrdinal("TicketType")),
                                reader.GetDecimal(reader.GetOrdinal("TicketPrice")),
                                reader.GetDateTime(reader.GetOrdinal("ValidDate")),
                                reader.GetDecimal(reader.GetOrdinal("BarcodeString")));
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

        public bool AlreadyCheckedIn(string barcode)
        {
            bool checkedIn = false;

            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("SELECT * FROM CheckinCheckout " +
                    "WHERE BarcodeString = @BarcodeString", connection);

                query.Parameters.AddWithValue("@BarcodeString", barcode);

                try
                {
                    connection.Open();
                    if (Convert.ToInt32(query.ExecuteScalar()) > 0)
                    {
                        checkedIn = true;
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }

            }

            return checkedIn;
        }

        public void CheckOut(string barcode, DateTime time)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("UPDATE CheckinCheckout " +
                    "SET Checkout = @Checkout " +
                    "WHERE BarcodeString = @BarcodeString", connection);

                query.Parameters.AddWithValue("@BarcodeString", barcode);
                query.Parameters.AddWithValue("@Checkout", time);

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

        public void CheckIn(string barcode, DateTime time)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("INSERT INTO CheckinCheckout " +
                    "(BarcodeString, Checkin)" +
                    "VALUES(@BarcodeString, @Checkin)", connection);

                query.Parameters.AddWithValue("@BarcodeString", barcode);
                query.Parameters.AddWithValue("@Checkin", time);

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

        public bool NotUsed(string barcode)
        {
            bool ticketIsUsed = false;

            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                SqlCommand query = new SqlCommand("SELECT * FROM CheckinCheckout " +
                    "WHERE BarcodeString = @BarcodeString " +
                    "AND Checkout IS NOT NULL", connection);

                query.Parameters.AddWithValue("@BarcodeString", barcode);

                try
                {
                    connection.Open();
                    if (Convert.ToInt32(query.ExecuteScalar()) > 0)
                    {
                        ticketIsUsed = true;
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }

            }

            return ticketIsUsed;
        }
    }
}

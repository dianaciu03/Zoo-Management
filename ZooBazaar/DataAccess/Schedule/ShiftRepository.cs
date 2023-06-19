using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShiftRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        public ShiftDTO[] GetAllShifts()
        {
            List<ShiftDTO> shifts = new List<ShiftDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return shifts.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT * FROM Shifts", connection);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ShiftDTO shift = new ShiftDTO()
                        {
                            ShiftId = Convert.ToInt32(reader["ShiftId"].ToString()),
                            EmployeeId = Convert.ToInt32(reader["ShiftEmployeeId"].ToString()),
                            ShiftTime = Convert.ToDateTime(reader["ShiftTime"].ToString())
                        };
                    shifts.Add(shift);
                    }
                    reader.Close();
                    connection.Close();
                    return shifts.ToArray();
                }
            }
        }

        public ShiftDTO[] GetAllShifts(DateTime date)
        {
            List<ShiftDTO> shifts = new List<ShiftDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return shifts.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT * FROM Shifts WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) = @ShiftTime", connection);
                query.Parameters.AddWithValue("@ShiftTime", date.Date);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ShiftDTO shift = new ShiftDTO()
                        {
                            ShiftId = Convert.ToInt32(reader["ShiftId"].ToString()),
                            EmployeeId = Convert.ToInt32(reader["ShiftEmployeeId"].ToString()),
                            ShiftTime = Convert.ToDateTime(reader["ShiftTime"].ToString())
                        };
                        shifts.Add(shift);
                    }
                    reader.Close();
                    connection.Close();
                    return shifts.ToArray();
                }
            }
        }
        public ShiftDTO[] GetShiftsWithinRange(DateTime start, DateTime end)
        {
            List<ShiftDTO> shifts = new List<ShiftDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return shifts.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT * FROM Shifts " +
                                                  "   WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) >= @StartDate" +
                                                  "   AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) <= @EndDate" +
                                                  "   ORDER BY ShiftTime asc", connection);
                query.Parameters.AddWithValue("@StartDate", start.Date);
                query.Parameters.AddWithValue("@EndDate", end.Date);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ShiftDTO shift = new ShiftDTO()
                        {
                            ShiftId = Convert.ToInt32(reader["ShiftId"].ToString()),
                            EmployeeId = Convert.ToInt32(reader["ShiftEmployeeId"].ToString()),
                            ShiftTime = Convert.ToDateTime(reader["ShiftTime"].ToString())
                        };
                        shifts.Add(shift);
                    }
                    reader.Close();
                    connection.Close();
                    return shifts.ToArray();
                }
            }
        }
        public void DeleteShiftsWithinRange(DateTime start, DateTime end)
        {
            List<ShiftDTO> shifts = new List<ShiftDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return; }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("Delete FROM Shifts " +
                                                  "   WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) >= @StartDate" +
                                                  "   AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) <= @EndDate;", connection);
                query.Parameters.AddWithValue("@StartDate", start.Date);
                query.Parameters.AddWithValue("@EndDate", end.Date);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ShiftDTO shift = new ShiftDTO()
                        {
                            ShiftId = Convert.ToInt32(reader["ShiftId"].ToString()),
                            EmployeeId = Convert.ToInt32(reader["ShiftEmployeeId"].ToString()),
                            ShiftTime = Convert.ToDateTime(reader["ShiftTime"].ToString())
                        };
                        shifts.Add(shift);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public int[] GetShiftEmployees(DateTime date)
        {
            List<int> employeeIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employeeIDs.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT DISTINCT ShiftEmployeeID FROM Shifts WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, ShiftTime))) = @ShiftTime", connection);
                query.Parameters.AddWithValue("@ShiftTime", date.Date);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int employeeId = Convert.ToInt32(reader["ShiftEmployeeId"].ToString());
                        employeeIDs.Add(employeeId);

                    }
                    reader.Close();
                    connection.Close();
                    return employeeIDs.ToArray();
                }
            }
        }

        public void AddShift(ShiftDTO shift)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {

                //connection.Open();
                SqlCommand query = new SqlCommand(" INSERT INTO Shifts (ShiftEmployeeId, ShiftTime)" +
                                                  " VALUES (@employeeId, @time)", connection);

                query.Parameters.AddWithValue("@employeeId", shift.EmployeeId);
                query.Parameters.AddWithValue("@time", shift.ShiftTime);
                DateTime startOfWeek;
                if (shift.ShiftTime.DayOfWeek == DayOfWeek.Sunday)
                    startOfWeek = shift.ShiftTime.Date.AddDays(-6);
                else
                    startOfWeek = shift.ShiftTime.Date.AddDays(-(int)shift.ShiftTime.DayOfWeek + 1); //Start of week = today - today + 1
                DateTime endOfWeek = startOfWeek.AddDays(6);

                //query.Parameters.AddWithValue("@weekStart", startOfWeek);
                //query.Parameters.AddWithValue("@weekEnd", endOfWeek.AddDays(1));
                
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
    }
}

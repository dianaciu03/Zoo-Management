using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StatisticsRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public int TotalEmployees()
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                int employeeCount = 0;
                SqlCommand query = new SqlCommand("SELECT COUNT(EmployeeID) FROM Employees", connection);

                try
                {
                    connection.Open();
                    employeeCount = (int)query.ExecuteScalar();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return employeeCount;
            }
        }

        public int TotalAnimals()
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                int employeeCount = 0;
                SqlCommand query = new SqlCommand("SELECT COUNT(AnimalID) FROM Animals", connection);

                try
                {
                    connection.Open();
                    employeeCount = (int)query.ExecuteScalar();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return employeeCount;
            }
        }

        public int TotalSpecies()
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                int employeeCount = 0;
                SqlCommand query = new SqlCommand("SELECT COUNT(DISTINCT Species) FROM Animals", connection);

                try
                {
                    connection.Open();
                    employeeCount = (int)query.ExecuteScalar();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return employeeCount;
            }
        }

        public int CurrentVisitors()
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                int employeeCount = 0;
                SqlCommand query = new SqlCommand("SELECT Count(BarcodeString) FROM sales " +
                    "WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, salesDate))) = @Date " +
                    "AND Checkout IS NULL", connection);

                query.Parameters.AddWithValue("@Date", DateTime.Today);

                try
                {
                    connection.Open();
                    employeeCount = (int)query.ExecuteScalar();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return employeeCount;
            }
        }

        public int TotalVisitorsOnGivenDay(DateTime date)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                int employeeCount = 0;
                SqlCommand query = new SqlCommand("SELECT Count(BarcodeString) FROM sales " +
                    "WHERE CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, salesDate))) = @Date ", connection);

                query.Parameters.AddWithValue("@Date", date.Date);

                try
                {
                    connection.Open();
                    employeeCount = (int)query.ExecuteScalar();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
                return employeeCount;
            }
        }
    }
}

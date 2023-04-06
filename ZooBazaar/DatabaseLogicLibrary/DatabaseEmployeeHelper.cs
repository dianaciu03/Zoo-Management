using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseLogicLibrary
{
    public class DatabaseEmployeeHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public int NewEmployeeID()
        {
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT MAX(EmployeeID) FROM Employees", connection);

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

        public List<EmployeeDTO> GetAllEmployees() // Gets all animals in the animal database and returns them as a list of Animal Objects
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employees; }

                SqlCommand query = new SqlCommand("SELECT * FROM Employees", connection);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        reader.Close();
                        connection.Close();
                        return employees;
                    }

                    EmployeeDTO employee = new EmployeeDTO(
                        reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                        reader.GetString(reader.GetOrdinal("Gender")),
                        reader.GetString(reader.GetOrdinal("Address")),
                        reader.GetString(reader.GetOrdinal("Phone")),
                        reader.GetString(reader.GetOrdinal("Password")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetInt32(reader.GetOrdinal("WeeklyHours")),
                        reader.GetString(reader.GetOrdinal("EmployeeType")));

                    employees.Add(employee);
                }
            }
            return employees;
        }

        public void AddUpdateEmployee(EmployeeDTO employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return; }

                SqlCommand existsInDatabase = new SqlCommand($"SELECT COUNT(*) FROM Employees WHERE EmployeeID = {employee.ID}");
                if ((int)existsInDatabase.ExecuteScalar() > 0)
                {
                    UpdateEmployee(employee, connection);
                }
                else
                {
                    AddNewEmployee(employee, connection);
                }
                connection.Close();
            }
        }

        private void UpdateEmployee(EmployeeDTO employee, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Employees" +
                                           "VALUES (@EmployeeID,@FirstaName,@LastName,@Birthdate,@Birthdate,@Gender,@Address,@Phone,@Password, @Email, @EmployeeType, @WeeklyHours)", connection))
            {
                command.Parameters.AddWithValue("@EmployeeID", employee.ID);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@Birthdate", employee.BirthDate.ToString());
                command.Parameters.AddWithValue("@Gender", employee.PersonGender);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@Phone", employee.Phone);
                command.Parameters.AddWithValue("@Password", employee.Password);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@EmployeeType", employee.GetType().ToString());
                command.Parameters.AddWithValue("@WeeklyHours", employee.HoursPerWeek.ToString());

                command.ExecuteNonQuery();
            }
        }

        private void AddNewEmployee(EmployeeDTO employee, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Employees" +
                               "VALUES (@EmployeeID,@FirstaName,@LastName,@Birthdate,@Birthdate,@Gender,@Address,@Phone,@Password, @Email, @EmployeeType, @WeeklyHours)", connection))
            {
                command.Parameters.AddWithValue("@EmployeeID", employee.ID);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@Birthdate", employee.BirthDate.ToString());
                command.Parameters.AddWithValue("@Gender", employee.PersonGender);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@Phone", employee.Phone);
                command.Parameters.AddWithValue("@Password", employee.Password);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@EmployeeType", employee.GetType().ToString());
                command.Parameters.AddWithValue("@WeeklyHours", employee.HoursPerWeek.ToString());

                command.ExecuteNonQuery();
            }
        }

        public List<EmployeeDTO> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeType)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();



            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employees; }


                //Dynamic SQL query to find the festivals that the user is searching for.
                SqlCommand query = new SqlCommand("SELECT * FROM Employees WHERE " +
                    "(FirstName LIKE '%' + @FirstName ) AND " +
                    "(LastName LIKE '%' @LastName) AND " +
                    "(WeeklyHours = @WeeklyHours) AND " +
                    "(EmployeeType = @EmployeeType) AND " +

                    "ORDER BY Name;", connection);

                query.Parameters.AddWithValue("@FirstName", firstName);
                query.Parameters.AddWithValue("@LastName", lastname);
                query.Parameters.AddWithValue("@WeeklyHours", weeklyHours);
                query.Parameters.AddWithValue("@EmployeeType", employeeType);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeDTO employee = new EmployeeDTO(
                        reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                        reader.GetString(reader.GetOrdinal("FirstName")),
                        reader.GetString(reader.GetOrdinal("LastName")),
                        reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                        reader.GetString(reader.GetOrdinal("Gender")),
                        reader.GetString(reader.GetOrdinal("Address")),
                        reader.GetString(reader.GetOrdinal("Phone")),
                        reader.GetString(reader.GetOrdinal("Password")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetInt32(reader.GetOrdinal("WeeklyHours")),
                        reader.GetString(reader.GetOrdinal("EmployeeType")));

                        employees.Add(employee);
                    }
                    reader.Close();
                    connection.Close();
                    return employees;
                }
            }
        }
    }
}

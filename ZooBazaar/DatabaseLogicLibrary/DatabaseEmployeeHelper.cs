using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary;

namespace DatabaseLogicLibrary
{
    public class DatabaseEmployeeHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public List<Employee> GetEmployees() // Gets all animals in the animal database and returns them as a list of Animal Objects
        {
            List<Employee> employees = new List<Employee>();

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

                    Employee employee = null;

                    int employeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                    string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                    DateTime birthdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));
                    string gender = reader.GetString(reader.GetOrdinal("Gender"));
                    string address = reader.GetString(reader.GetOrdinal("Address"));
                    string phone = reader.GetString(reader.GetOrdinal("Phone"));
                    string password = reader.GetString(reader.GetOrdinal("Password"));
                    string email = reader.GetString(reader.GetOrdinal("Email"));
                    int hoursPerWeek = reader.GetInt32(reader.GetOrdinal("WeeklyHours"));

                    switch (reader.GetString(reader.GetOrdinal("EmployeeType")))
                    {
                        case "AnimalAdministrator":
                            employee = new AnimalAdministrator(employeeID, firstName, lastName, birthdate, gender, address, phone, password, email);
                            break;
                        case "HRAdministrator":
                            employee = new HRAdministrator(employeeID, firstName, lastName, birthdate, password, address, phone, email, gender);
                            break;
                        case "CareTaker":
                            employee = new CareTaker(employeeID, firstName, lastName, birthdate, gender, address, phone, password, email, hoursPerWeek);
                            break;
                        case "Manager":
                            employee = new Manager(employeeID, firstName, lastName, birthdate, password, address, phone, email, gender);
                            break;
                        case "ResourcePlanner":
                            employee = new ResourcePlanner(employeeID, firstName, lastName, birthdate, password, address, phone, email, gender);
                            break;
                        case "ScheduleMaker":
                            employee = new ScheduleMaker(employeeID, firstName, lastName, birthdate, password, address, phone, email, gender);
                            break;
                        default:
                            break;
                    }

                    employees.Add(employee);
                }
            }
            return employees;
        }

        public void AddUpdateEmployee(Employee employee)
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

        private void UpdateEmployee(Employee employee, SqlConnection connection)
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

        private void AddNewEmployee(Employee employee, SqlConnection connection)
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
    }
}

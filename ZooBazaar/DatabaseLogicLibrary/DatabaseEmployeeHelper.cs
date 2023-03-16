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
    }
}

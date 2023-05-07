using DataAccess.DTOs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class EmployeeRepository:IEmployeeRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();
        
        public EmployeeRepository()
        {
            
        } 
        public List<EmployeeDTO> GetAllEmployees() // Gets all employees in the employee database and returns them as a list of employeeDTO Objects
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employees; }
                DateTime dateTime= DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT e.*,c.WeeklyHours FROM Employees AS e JOIN Contracts AS c ON e.EmployeeID = c.EmployeeID WHERE c.EndDate > @dateTime OR c.EndDate IS NULL", connection);
                query.Parameters.AddWithValue("@dateTime",dateTime);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeDTO employee = new EmployeeDTO()
                        {
                            id = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                            firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            lastName = reader.GetString(reader.GetOrdinal("LastName")),
                            birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                            gender = reader.GetString(reader.GetOrdinal("Gender")),
                            address = reader.GetString(reader.GetOrdinal("Address")),
                            phone = reader.GetString(reader.GetOrdinal("Phone")),
                            role = reader.GetString(reader.GetOrdinal("EmployeeType")),
                            password = reader.GetString(reader.GetOrdinal("Password")),
                            email = reader.GetString(reader.GetOrdinal("Email")),
                            hoursPerWeek = reader.GetInt32(reader.GetOrdinal("WeeklyHours"))
                        };
                        employees.Add(employee);
                    }

                    reader.Close();
                    connection.Close();
                    return employees;
                }
            }
        }
        public void AddUpdateEmployee(EmployeeDTO employee, ContractDTO contract, EmergencyContactDTO emergencyContact)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                //try
                {
                    connection.Open();
                    SqlCommand existsInDatabase = new SqlCommand($"SELECT EmployeeID FROM Employees WHERE EmployeeID = @EmployeeId", connection);
                    existsInDatabase.Parameters.AddWithValue("@EmployeeID", employee.id);
                    int existsInDB = Convert.ToInt32(existsInDatabase.ExecuteScalar());
                    if (existsInDB > 0)
                    {
                        UpdateEmployee(employee, connection);
                    }
                    else
                    {
                        AddNewEmployee(employee, contract, emergencyContact, connection);
                    }
                }
                //catch (SqlException) { }

                connection.Close();
            }
        }

        private void UpdateEmployee(EmployeeDTO employee, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("UPDATE dbo.Employees SET FirstName=@FirstName ,LastName=@LastName ,BirthDate=@BirthDate ,Gender=@Gender ,Address=@Address,Phone=@Phone,Password=@Password,Email=@Email,EmployeeType=@EmployeeType WHERE EmployeeID = @employeeID", connection))
            {
                command.Parameters.AddWithValue("@employeeID", employee.id);
                command.Parameters.AddWithValue("@FirstName", employee.firstName);
                command.Parameters.AddWithValue("@LastName", employee.lastName);
                command.Parameters.AddWithValue("@BirthDate", employee.birthDate);
                command.Parameters.AddWithValue("@Gender", employee.gender);
                command.Parameters.AddWithValue("@Address", employee.address);
                command.Parameters.AddWithValue("@Phone", employee.phone);
                command.Parameters.AddWithValue("@Password", employee.password);
                command.Parameters.AddWithValue("@Email", employee.email);
                command.Parameters.AddWithValue("@EmployeeType", employee.role);

                command.ExecuteNonQuery();
            }
        }

        private void AddNewEmployee(EmployeeDTO employee, ContractDTO contract, EmergencyContactDTO emergencyContact, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(
                " DECLARE @employeeIdentity INT" +
                " INSERT INTO Employees" +
                " VALUES (@FirstName, @LastName, @Birthdate, @Gender, @Address, @Phone, @Password, @Email, @EmployeeType)" +
                " SET @employeeIdentity = @@IDENTITY" +
                " INSERT INTO Contracts Values (@employeeIdentity, @StartDate, @EndDate, @WeeklyHours, @Salary)" +
                " INSERT INTO EmergencyContacts Values (@ContactFirstName, @ContactLastName, @Relationship, @ContactPhone, @employeeIdentity)", connection))
            {
                command.Parameters.AddWithValue("@FirstName", employee.firstName);
                command.Parameters.AddWithValue("@LastName", employee.lastName);
                command.Parameters.AddWithValue("@Birthdate", employee.birthDate);
                command.Parameters.AddWithValue("@Gender", employee.gender);
                command.Parameters.AddWithValue("@Address", employee.address);
                command.Parameters.AddWithValue("@Phone", employee.phone);
                command.Parameters.AddWithValue("@Password", employee.password);
                command.Parameters.AddWithValue("@Email", employee.email);
                command.Parameters.AddWithValue("@EmployeeType", employee.role.ToString());

                command.Parameters.AddWithValue("@StartDate", contract.startDate);
                if (contract.endDate != null)
                    command.Parameters.AddWithValue("@EndDate", contract.endDate);
                else
                    command.Parameters.AddWithValue("@EndDate", DBNull.Value);
                command.Parameters.AddWithValue("@WeeklyHours", contract.hoursPerWeek);
                command.Parameters.AddWithValue("@Salary", contract.salary);

                command.Parameters.AddWithValue("@ContactFirstName", emergencyContact.firstName);
                command.Parameters.AddWithValue("@ContactLastName", emergencyContact.lastName);
                command.Parameters.AddWithValue("@Relationship", emergencyContact.relationship);
                command.Parameters.AddWithValue("@ContactPhone", emergencyContact.phone);
                command.ExecuteNonQuery();
            }
        }

        public List<EmployeeDTO> SearchForEmployee(string firstName, string lastname, int weeklyHours, string employeeRole)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employees; }
                SqlCommand query;
                DateTime dateTime = DateTime.Now;
                if (weeklyHours == 40)
                {
                     query= new SqlCommand("SELECT e.*, c.WeeklyHours FROM Employees AS e JOIN Contracts AS c ON e.EmployeeID = c.EmployeeID WHERE (FirstName LIKE '%' + @FirstName + '%') AND(LastName LIKE '%' + @LastName + '%') AND (WeeklyHours = @WeeklyHours) AND (EmployeeType LIKE '%' + @EmployeeType + '%') AND (c.EndDate > @dateTime OR c.EndDate IS NULL)"
                         , connection);
                }
                else
                {
                    query= new SqlCommand("SELECT e.*,c.WeeklyHours FROM Employees AS e JOIN Contracts AS c ON e.EmployeeID = c.EmployeeID WHERE (FirstName LIKE '%' + @FirstName + '%') AND (LastName LIKE '%' + @LastName + '%') AND (WeeklyHours <= @WeeklyHours) AND (EmployeeType LIKE '%' + @EmployeeType + '%') AND (c.EndDate > @dateTime OR c.EndDate IS NULL)"
                        , connection);
                }
                query.Parameters.AddWithValue("@dateTime", dateTime);
                query.Parameters.AddWithValue("@FirstName", firstName);
                query.Parameters.AddWithValue("@LastName", lastname);
                query.Parameters.AddWithValue("@WeeklyHours", weeklyHours);
                query.Parameters.AddWithValue("@EmployeeType", employeeRole);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeDTO employee = new EmployeeDTO
                        {
                            id = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                            firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            lastName = reader.GetString(reader.GetOrdinal("LastName")),
                            birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                            gender = reader.GetString(reader.GetOrdinal("Gender")),
                            address = reader.GetString(reader.GetOrdinal("Address")),
                            phone = reader.GetString(reader.GetOrdinal("Phone")),
                            role = reader.GetString(reader.GetOrdinal("EmployeeType")),
                            password = reader.GetString(reader.GetOrdinal("Password")),
                            email = reader.GetString(reader.GetOrdinal("Email")),
                            hoursPerWeek = reader.GetInt32(reader.GetOrdinal("WeeklyHours"))
                        };

                        employees.Add(employee);
                    }
                    reader.Close();
                    connection.Close();
                    return employees;
                }
            }
        }
        public EmployeeDTO? GetEmployeeByEmail(string email)
        {
            EmployeeDTO employee;
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM Employees Where Email = @email", connection);
                query.Parameters.AddWithValue("email", email);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;
                    employee = new EmployeeDTO
                    {
                        id = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                        firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        lastName = reader.GetString(reader.GetOrdinal("LastName")),
                        birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                        gender = reader.GetString(reader.GetOrdinal("Gender")),
                        address = reader.GetString(reader.GetOrdinal("Address")),
                        phone = reader.GetString(reader.GetOrdinal("Phone")),
                        role = reader.GetString(reader.GetOrdinal("EmployeeType")),
                        password = reader.GetString(reader.GetOrdinal("Password")),
                        email = reader.GetString(reader.GetOrdinal("Email"))
                    };
                    reader.Close();
                    connection.Close();
                    return employee;
                }
            }
        }
        public EmployeeDTO? GetEmployeeById(int id)
        {
            EmployeeDTO employee;
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM Employees Where EmployeeID = @id", connection);
                query.Parameters.AddWithValue("id", id);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;
                    employee = new EmployeeDTO
                    {
                        id = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                        firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        lastName = reader.GetString(reader.GetOrdinal("LastName")),
                        birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                        gender = reader.GetString(reader.GetOrdinal("Gender")),
                        address = reader.GetString(reader.GetOrdinal("Address")),
                        phone = reader.GetString(reader.GetOrdinal("Phone")),
                        role = reader.GetString(reader.GetOrdinal("EmployeeType")),
                        password = reader.GetString(reader.GetOrdinal("Password")),
                        email = reader.GetString(reader.GetOrdinal("Email"))
                    };
                    reader.Close();
                    connection.Close();
                    return employee;
                }
            }
        }
        public EmployeeDTO[] GetEmployeesByTask(int taskId)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                connection.Open();
                SqlCommand query = new SqlCommand(
                    "SELECT * FROM Employees e " +
                    "Inner join TaskEmployeeRelation tr on e.EmployeeID = tr.EmployeeID " +
                    "Where tr.TaskID = @taskId ", 
                    connection);
                query.Parameters.AddWithValue("@taskId", taskId);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeDTO employee = new EmployeeDTO
                        {
                            id = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                            firstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            lastName = reader.GetString(reader.GetOrdinal("LastName")),
                            birthDate = reader.GetDateTime(reader.GetOrdinal("Birthdate")),
                            gender = reader.GetString(reader.GetOrdinal("Gender")),
                            address = reader.GetString(reader.GetOrdinal("Address")),
                            phone = reader.GetString(reader.GetOrdinal("Phone")),
                            role = reader.GetString(reader.GetOrdinal("EmployeeType")),
                            password = reader.GetString(reader.GetOrdinal("Password")),
                            email = reader.GetString(reader.GetOrdinal("Email"))
                        };
                        employees.Add(employee);
                    }
                    
                    reader.Close();
                    connection.Close();
                    return employees.ToArray();
                }
            }
        }

        public ContractDTO GetContractById(int id)
        {
            ContractDTO contractDTO;
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM Contracts Where EmployeeID = @id", connection);
                query.Parameters.AddWithValue("id", id);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    try
                    {
                        reader.Read();

                        contractDTO = new ContractDTO
                        {
                            employeeId = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                            startDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
                            endDate = reader.GetDateTime(reader.GetOrdinal("EndDate")),
                            hoursPerWeek = (int)reader.GetSqlInt32(reader.GetOrdinal("WeeklyHours")),
                            salary = (decimal)reader.GetSqlDecimal(reader.GetOrdinal("Salary"))
                        };
                        reader.Close();
                        connection.Close();
                        return contractDTO;
                    }
                    catch
                    {
                        return new ContractDTO();
                    }
                }
            }
        }
    }
}

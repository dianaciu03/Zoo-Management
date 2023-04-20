﻿using DataAccess.DTOs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class EmployeeRepository
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
                return i + 1; //+1 beacuse we need a new employee id so we get the current highest in database + 1
            }

        }

        public List<EmployeeDTO> GetAllEmployees() // Gets all employees in the employee database and returns them as a list of employeeDTO Objects
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return employees; }

                SqlCommand query = new SqlCommand("SELECT * FROM Employees", connection);

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
                            email = reader.GetString(reader.GetOrdinal("Email"))
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
            using (SqlCommand command = new SqlCommand("INSERT INTO Employees" +
                                           "VALUES (@EmployeeID,@FirstaName,@LastName,@Birthdate,@Birthdate,@Gender,@Address,@Phone,@Password, @Email, @EmployeeType, @WeeklyHours)", connection))
            {
                command.Parameters.AddWithValue("@EmployeeID", employee.id);
                command.Parameters.AddWithValue("@FirstName", employee.firstName);
                command.Parameters.AddWithValue("@LastName", employee.lastName);
                command.Parameters.AddWithValue("@Birthdate", employee.birthDate);
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
    }
}

using DatabaseLogicLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLibrary
{
    public class DatabaseZooTaskHelper
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public int NewZooTaskID()
        {
            int i = 0;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT MAX(TaskID) FROM Tasks", connection);

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
                return i + 1; //+1 beacuse we need a new task id so we get the current highest in database + 1
            }

        }

        public ZooTaskDTO GetTask(int taskID)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Tasks WHERE TaskID = @TaskID", connection);
                query.Parameters.AddWithValue("@TaskID", taskID);


                ZooTaskDTO task;
                try 
                { 
                    connection.Open();

                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        task = new ZooTaskDTO(
                            reader.GetInt32(reader.GetOrdinal("TaskID")),
                            reader.GetString(reader.GetOrdinal("TaskName")),
                            reader.GetString(reader.GetOrdinal("TaskDescription")),
                            reader.GetDateTime(reader.GetOrdinal("TaskDate")),
                            reader.GetInt32(reader.GetOrdinal("TaskDuration")),
                            reader.GetString(reader.GetOrdinal("TaskSpecies")),
                            reader.GetString(reader.GetOrdinal("TaskZone")),
                            reader.GetInt32(reader.GetOrdinal("TaskEnclosureNumber")),
                            reader.GetString(reader.GetOrdinal("TaskStatus")));
                          
                        reader.Close();

                    }

                }
                catch (SqlException) { return null; }

                finally
                {
                    connection.Close();
                }
            return task;
            }
            
        }

        public void AddTask(ZooTaskDTO task)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("INSERT INTO Tasks " +
                    "(TaskID, TaskName, TaskDescription, TaskDate, TaskDuration, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskStatus)" +
                    "VALUES(@TaskID, @TaskName, @TaskDescription, @TaskDate, @TaskDuration, @TaskSpecies, @TaskZone, @TaskEnclosureNumber, @TaskStatus)");

                query.Parameters.AddWithValue("@TaskID", task.ID);
                query.Parameters.AddWithValue("@TaskName", task.Name);
                query.Parameters.AddWithValue("@TaskDescription", task.Description);
                query.Parameters.AddWithValue("@TaskDate", task.TaskDateTime);
                query.Parameters.AddWithValue("@TaskDuration", task.EstimatedDuration);
                query.Parameters.AddWithValue("@TaskSpecies", task.Species);
                query.Parameters.AddWithValue("@TaskZone", task.EnclosureArea);
                query.Parameters.AddWithValue("@TaskEnclosureNumber", task.EnclosureNumber);
                query.Parameters.AddWithValue("@TaskStatus", task.Status);

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

        public void RemoveTask(int taskID)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("DELETE FROM Tasks WHERE TaskID = @TaskID;");
                query.Parameters.AddWithValue("@TaskID", taskID);


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

        public void AssignEmployee(int employeeID, string taskID)
        {
            int newAssigmentID = 0;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT MAX(TaskAssignmentID) FROM Tasks", connection);

                try
                {
                    connection.Open();
                    if (query.ExecuteScalar() != DBNull.Value)
                    {
                        newAssigmentID = (Int32)query.ExecuteScalar();
                    }
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
            }
            newAssigmentID++;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {

                SqlCommand command = new SqlCommand("INSERT INTO TaskEmployeeRelation " +
                    "VALUES (@TaskAssignmentID,@EmployeeID,@TaskID); ", connection);

                command.Parameters.AddWithValue("@TaskAssignmentID", newAssigmentID);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@TaskID", taskID);

                try 
                { 
                    connection.Open(); 
                    command.ExecuteNonQuery();
                }
                catch (SqlException) { }
                finally 
                { 
                    connection.Close(); 
                }
            }
        }

        public void UnassignEmployee(int employeeID, int taskID)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("REMOVE FROM TaskEmployeeRelation WHERE " +
                    "TaskID = @TaskID AND EmployeeID = @EmployeeID", connection);

                query.Parameters.AddWithValue("@TaskID", taskID);
                query.Parameters.AddWithValue("@EmployeeID", employeeID);

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

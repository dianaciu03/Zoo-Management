using DataAccess.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TaskRepository
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
        public ZooTaskDTO[] GetAllTasks()
        {
            List<ZooTaskDTO> tasks = new List<ZooTaskDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return tasks.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand("SELECT * FROM Tasks", connection);
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ZooTaskDTO task = new ZooTaskDTO(
                            Convert.ToInt32(reader["TaskID"].ToString()),
                            reader["TaskName"].ToString(),
                            reader["TaskDescription"].ToString(),
                            Convert.ToDateTime(reader["TaskDate"].ToString()),
                            Convert.ToInt32(reader["TaskDuration"].ToString()),
                            reader["TaskSpecies"].ToString(),
                            reader["TaskZone"].ToString(),
                            Convert.ToInt32(reader["TaskEnclosureNumber"]),
                            reader["TaskStatus"].ToString(),
                            Convert.IsDBNull(reader["TaskAnimalID"]) ? null : (int?)Convert.ToInt32(reader["TaskAnimalID"])
                        );
                        tasks.Add(task);
                    }
                    reader.Close();
                    connection.Close();
                    return tasks.ToArray();
                }
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

        public ZooTaskDTO[] GetTasksByCaretaker(int employeeId)
        {
            List<ZooTaskDTO> foundTasks = new List<ZooTaskDTO>();
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                (
                    "Select * From Tasks t " +
                    "Inner Join TaskEmployeeRelation tr on t.TaskID = tr.TaskID " +
                    "Where tr.EmployeeID = @EmployeeID "
                , connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZooTaskDTO task = new ZooTaskDTO(
                        reader.GetInt32(reader.GetOrdinal("TaskID")),
                        reader.GetString(reader.GetOrdinal("TaskName")),
                        reader.GetString(reader.GetOrdinal("TaskDescription")),
                        reader.GetDateTime(reader.GetOrdinal("TaskDate")),
                        reader.GetInt32(reader.GetOrdinal("TaskDuration")),
                        reader.GetString(reader.GetOrdinal("TaskSpecies")),
                        reader.GetString(reader.GetOrdinal("TaskZone")),
                        reader.GetInt32(reader.GetOrdinal("TaskEnclosureNumber")),
                        reader.GetString(reader.GetOrdinal("TaskStatus"))
                    );
                    foundTasks.Add(task);
                }
                reader.Close();
            }
            return foundTasks.ToArray();
        }

        public void AddTask(ZooTaskDTO task)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                connection.Open();
                SqlCommand query = new SqlCommand("INSERT INTO Tasks " +
                    "(TaskName, TaskDescription, TaskDate, TaskDuration, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskStatus, TaskAnimalID)" +
                    "VALUES(@TaskName, @TaskDescription, @TaskDate, @TaskDuration, @TaskSpecies, @TaskZone, @TaskEnclosureNumber, @TaskStatus, @TaskAnimalID)", connection);

                query.Parameters.AddWithValue("@TaskName", task.Name);
                query.Parameters.AddWithValue("@TaskDescription", task.Description);
                query.Parameters.AddWithValue("@TaskDate", task.TaskDateTime);
                query.Parameters.AddWithValue("@TaskDuration", task.EstimatedDuration);
                query.Parameters.AddWithValue("@TaskSpecies", task.Species);
                query.Parameters.AddWithValue("@TaskZone", task.EnclosureArea);
                query.Parameters.AddWithValue("@TaskEnclosureNumber", task.EnclosureNumber);
                query.Parameters.AddWithValue("@TaskStatus", task.Status);
                if (task.AnimalID != null)
                    query.Parameters.AddWithValue("@TaskAnimalID", task.AnimalID);
                else
                    query.Parameters.AddWithValue("@TaskAnimalID", DBNull.Value);
                query.ExecuteNonQuery();
                /*try
                {
                    connection.Open();
                    query.ExecuteNonQuery();
                }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }*/

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

        public void AssignEmployee(int employeeID, int taskID)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {

                SqlCommand command = new SqlCommand("INSERT INTO TaskEmployeeRelation " +
                    "VALUES (@EmployeeID,@TaskID); ", connection);

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

using DataAccess.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TaskRepository
    {
        ConnectionHelper connectionHelper = new ConnectionHelper();

        public ZooTaskDTO[] GetAllTasks()
        {
            List<ZooTaskDTO> tasks = new List<ZooTaskDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return tasks.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand(" SELECT * FROM Tasks" +
                                                  " Where TaskDate >= @today", connection);

                query.Parameters.AddWithValue("@today", DateTime.Today.Date);
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
                            Convert.IsDBNull(reader["TaskAnimalID"]) ? null : (int?)Convert.ToInt32(reader["TaskAnimalID"]),
                            Convert.IsDBNull(reader["Repetitive"]) ? null : (reader["Repetitive"].ToString())
                        );
                        tasks.Add(task);
                    }
                    reader.Close();
                    connection.Close();
                    return tasks.ToArray();
                }
            }
        }
        public ZooTaskDTO[] GetDailyTasks()
        {
            List<ZooTaskDTO> tasks = new List<ZooTaskDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return tasks.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand(" SELECT TaskName, TaskDescription, " + 
                                                  " DATEPART(HOUR, TaskDate) AS TaskHour, " + 
                                                  " DATEPART(MINUTE, TaskDate) AS TaskMinute, " +
                                                  " TaskDuration, TaskStatus, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskAnimalID, Repetitive " +
                                                  "     FROM Tasks " +
                                                  "     WHERE Repetitive = @daily " +
                                                  "     GROUP BY TaskName, TaskDescription, " +
                                                  "              DATEPART(HOUR, TaskDate), " +
                                                  "              DATEPART(MINUTE, TaskDate), " +
                                                  "              TaskDuration, TaskStatus, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskAnimalID, Repetitive; ", connection);

                query.Parameters.AddWithValue("@daily", "Daily");
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ZooTaskDTO task = new ZooTaskDTO(
                            0,
                            reader["TaskName"].ToString(),
                            reader["TaskDescription"].ToString(),
                            new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(reader["TaskHour"]), Convert.ToInt32(reader["TaskMinute"]), 0),
                            Convert.ToInt32(reader["TaskDuration"].ToString()),
                            reader["TaskSpecies"].ToString(),
                            reader["TaskZone"].ToString(),
                            Convert.ToInt32(reader["TaskEnclosureNumber"]),
                            reader["TaskStatus"].ToString(),
                            Convert.IsDBNull(reader["TaskAnimalID"]) ? null : (int?)Convert.ToInt32(reader["TaskAnimalID"]),
                            Convert.IsDBNull(reader["Repetitive"]) ? null : (reader["Repetitive"].ToString())
                        );
                        tasks.Add(task);
                    }
                    reader.Close();
                    connection.Close();
                    return tasks.ToArray();
                }
            }
        }
        public ZooTaskDTO[] GetWeeklyTasks()
        {
            List<ZooTaskDTO> tasks = new List<ZooTaskDTO>();
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                try { connection.Open(); }
                catch (SqlException) { return tasks.ToArray(); }
                DateTime dateTime = DateTime.Now;
                SqlCommand query = new SqlCommand(" SELECT TaskName, TaskDescription, " +
                                                  "     DATEPART(WEEKDAY, TaskDate) AS TaskWeekDay, " +
                                                  "     DATEPART(HOUR, TaskDate) AS TaskHour, " +
                                                  "     DATEPART(MINUTE, TaskDate) AS TaskMinute, " +
                                                  "     TaskDuration, TaskStatus, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskAnimalID, Repetitive " +
                                                  " FROM Tasks " +
                                                  " WHERE Repetitive = @weekly " +
                                                  " GROUP BY TaskName, TaskDescription," +
                                                  "     DATEPART(WEEKDAY, TaskDate), " +
                                                  "     DATEPART(HOUR, TaskDate)," +
                                                  "     DATEPART(MINUTE, TaskDate)," +
                                                  "     TaskDuration, TaskStatus, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskAnimalID, Repetitive; ", connection);

                query.Parameters.AddWithValue("@weekly", "Weekly");
                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int weekday = Convert.ToInt32(reader["TaskWeekDay"]) - 1;
                        DateTime readDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(reader["TaskHour"]), Convert.ToInt32(reader["TaskMinute"]), 0);
                        for (int i = 0; i < 7; i++)
                        {
                            if ((DayOfWeek)weekday == readDateTime.DayOfWeek)
                            {
                                break;
                            }
                            readDateTime = readDateTime.AddDays(1);
                        }

                        ZooTaskDTO task = new ZooTaskDTO(
                            0,
                            reader["TaskName"].ToString(),
                            reader["TaskDescription"].ToString(),
                            readDateTime,
                            Convert.ToInt32(reader["TaskDuration"].ToString()),
                            reader["TaskSpecies"].ToString(),
                            reader["TaskZone"].ToString(),
                            Convert.ToInt32(reader["TaskEnclosureNumber"]),
                            reader["TaskStatus"].ToString(),
                            Convert.IsDBNull(reader["TaskAnimalID"]) ? null : (int?)Convert.ToInt32(reader["TaskAnimalID"]),
                            Convert.IsDBNull(reader["Repetitive"]) ? null : (reader["Repetitive"].ToString())
                        );
                        tasks.Add(task);
                    }
                    reader.Close();
                    connection.Close();
                    return tasks.ToArray();
                }
            }
        }


        public ZooTaskDTO? GetTask(int taskID)
        {
            ZooTaskDTO task;

            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Tasks WHERE TaskID = @TaskID ", connection);
                query.Parameters.AddWithValue("@TaskID", taskID);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                if (!reader.Read()) return null;

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
        public void UpdateTaskStatus(string status, int taskId)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {
                SqlCommand query = new SqlCommand("Update Tasks Set TaskStatus = @TaskStatus WHERE TaskID = @TaskID", connection);
                query.Parameters.AddWithValue("@TaskID", taskId);
                query.Parameters.AddWithValue("@TaskStatus", status);


                ZooTaskDTO task;
                try
                {
                    connection.Open();

                    query.ExecuteNonQuery();

                }
                catch (SqlException) { return ; }

                finally
                {
                    connection.Close();
                }
            }
        }

        public void AddTask(ZooTaskDTO task)
        {
            SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue());
            using (connection)
            {
                connection.Open();
                SqlCommand query = new SqlCommand("INSERT INTO Tasks " +
                    "(TaskName, TaskDescription, TaskDate, TaskDuration, TaskSpecies, TaskZone, TaskEnclosureNumber, TaskStatus, TaskAnimalID, Repetitive)" +
                    "VALUES(@TaskName, @TaskDescription, @TaskDate, @TaskDuration, @TaskSpecies, @TaskZone, @TaskEnclosureNumber, @TaskStatus, @TaskAnimalID, @Repetitive)", connection);

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
                if (task.Repetitive != null)
                    query.Parameters.AddWithValue("Repetitive", task.Repetitive);
                else
                    query.Parameters.AddWithValue("Repetitive", DBNull.Value);

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
                connection.Open();

                SqlCommand query = new SqlCommand("DELETE FROM Tasks WHERE TaskID = @TaskID ", connection);
                query.Parameters.AddWithValue("@TaskID", taskID);
                query.ExecuteNonQuery();
            }
        }

        public void AssignEmployee(int employeeID, int taskID)
        {
            using (SqlConnection connection = new SqlConnection(connectionHelper.ConnectionValue()))
            {

                SqlCommand command = new SqlCommand("" +
                    " INSERT INTO TaskEmployeeRelation VALUES (@EmployeeID,@TaskID); " +
                    " Update Tasks Set TaskStatus = @TaskStatus WHERE TaskID = @TaskID ",
                    connection);

                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@TaskID", taskID);
                command.Parameters.AddWithValue("@TaskStatus", "Assigned");

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

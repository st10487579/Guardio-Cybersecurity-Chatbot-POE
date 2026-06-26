using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GuardioChatbot.Models;


namespace GuardioChatbot.Database
{
    public class TaskDatabase
    {
        private readonly string connectionString =
            "server=localhost;database=GuardioDB;uid=root;pwd=omolemo16/09/24;";

        // Test the database connection
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // CREATE - Add a task
        public bool AddTask(CyberTask task)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO CyberTasks
                                     (Title, Description, ReminderDate, IsCompleted)
                                     VALUES
                                     (@Title, @Description, @ReminderDate, @Completed)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Title", task.Title);
                    cmd.Parameters.AddWithValue("@Description", task.Description);
                    cmd.Parameters.AddWithValue("@ReminderDate", task.ReminderDate);
                    cmd.Parameters.AddWithValue("@Completed", task.IsCompleted);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }

        // READ - Get all tasks
        public List<CyberTask> GetTasks()
        {
            List<CyberTask> tasks = new List<CyberTask>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM CyberTasks ORDER BY Id DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CyberTask task = new CyberTask();

                        task.Id = Convert.ToInt32(reader["Id"]);
                        task.Title = reader["Title"].ToString();
                        task.Description = reader["Description"].ToString();

                        if (reader["ReminderDate"] != DBNull.Value)
                            task.ReminderDate = Convert.ToDateTime(reader["ReminderDate"]);

                        task.IsCompleted = Convert.ToBoolean(reader["IsCompleted"]);

                        tasks.Add(task);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            return tasks;
        }

        // UPDATE - Mark task as completed
        public bool MarkTaskCompleted(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE CyberTasks SET IsCompleted = 1 WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }

        // DELETE - Remove a task
        public bool DeleteTask(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM CyberTasks WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

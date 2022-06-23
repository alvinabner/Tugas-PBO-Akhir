using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Tugas_PBO_Akhir.Controller
{
    public class TodoDB
    {
        public static string createData(Dictionary<string, dynamic> data)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO todo (task,isdone,deadline)VALUES('{data["task"]}', {data["isdone"]}, '{data["deadline"]}');";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    return "berhasil";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public static string deleteData(string id)
        {
            try /* Deletion After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"Delete from todo where id={id}";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    return "berhasil";

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static Todo getDataByID(string id)
        {

            try 
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"Select * from todo where id={id} ";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    String task = dt.Rows[0]["task"].ToString();
                    bool isDone = bool.Parse(dt.Rows[0]["isdone"].ToString());
                    DateTime deadline = DateTime.Parse(dt.Rows[0]["deadline"].ToString());

                    cmd.Dispose();
                    connection.Close();

                    return new Todo(id,task,isDone,deadline);
                }
            }
            catch
            {
                return null;
            }

        }

        public static string updateData(string id, Dictionary<string,dynamic> data)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"update todo set task='{data["task"]}', isdone={data["isdone"]},deadline='{data["deadline"]}' where id={id}";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    return "berhasil";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static List<Todo> getAllData()
        {
            List<Todo> todoList = new List<Todo>();

            try 
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from todo";
                    cmd.CommandType = CommandType.Text;

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        String id = dt.Rows[i]["id"].ToString();
                        String task = dt.Rows[i]["task"].ToString();
                        bool isDone = bool.Parse(dt.Rows[i]["isdone"].ToString());
                        DateTime deadline = DateTime.Parse(dt.Rows[i]["deadline"].ToString());
                        Todo todo = new Todo(id, task, isDone, deadline);
                        todoList.Add(todo);
                    }

                    cmd.Dispose();
                    connection.Close();

                }
            }
            catch
            {

            }
            return todoList;

        }
    }
}
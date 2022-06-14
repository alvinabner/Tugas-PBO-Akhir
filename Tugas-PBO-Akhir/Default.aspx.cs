using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tugas_PBO_Akhir
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Todo> todoList = getAllTodo(null, null);
            foreach (Todo todo in todoList)
            {
                var status = (todo.isDone) ? "Finished" : "Unfinished";
                body.InnerHtml += $"<tr><td>{todo.id}</td><td>{todo.task}</td><td>{todo.deadline}</td><td>{status}</td><td><a class=\"btn btn-primary mr-2 \" href=\"Edit.aspx/?id={todo.id}\">Edit</a><a class=\"btn btn-danger mr-2 \" href=\"Delete.aspx/?id={todo.id}\">Delete</a></td></tr>";
            }
        }

        protected List<Todo> getAllTodo(object sender, EventArgs e)
        {
            List<Todo> todoList = new List<Todo>();

            try /* Select After Validations*/
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

                    warning.Text = dt.Rows[0]["deadline"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            return todoList;

        }

        
    }
}
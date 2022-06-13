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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                /* Insertion After Validations*/
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO todo (task,isdone,deadline)VALUES('{todo.Text}', {status.SelectedValue}, '{deadline.Text}');";
                    //cmd.CommandText = "Insert into employee values(@task,@isdone,@deadline)";
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.Add(new NpgsqlParameter());
                    //cmd.Parameters.Add(new NpgsqlParameter("@task", todo.Text));
                    //cmd.Parameters.Add(new NpgsqlParameter("@isdone", status.SelectedValue));
                    //cmd.Parameters.Add(new NpgsqlParameter("@deadline", deadline.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    //todo.Text = "";
                    //deadline.Text = "";
                    //Console.WriteLine("tess");
                    //status.Text = "";
                    lblmsg.Text = "berhasil";

                    Response.Redirect("Default.aspx");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                lblmsg.Text = ex.Message;

            }
        }
    }
}
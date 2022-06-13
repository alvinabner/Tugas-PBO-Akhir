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
            btnSelect_Click(null, null);



        }

        protected async void btnSelect_Click(object sender, EventArgs e) 
        {
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
                    cmd.Dispose();
                    connection.Close();



                    warning.Text = "Berhasil";
                    //GridView1.DataSource = dt;
                    //GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {
                warning.Text = "Berhasil";
            }
        }
    }
}
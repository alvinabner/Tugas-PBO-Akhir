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
    public partial class Edit : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            getDataByID(id);
            //Response.Redirect("~/");
        }

        protected void getDataByID(string id)
        {

            try /* Select After Validations*/
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

                    taskLabel.Text += " ("+task+")";
                    statusLabel.Text += " (" + ((isDone) ? "Finished" : "Unfinished") + ")";
                    dlLabel.Text  += " ("+deadline.ToString("MM/dd/yyyy hh:mm") +")";

                    cmd.Dispose();
                    connection.Close();

                }
            }
            catch (Exception ex)
            {

            }

        }
        protected void updateData(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            try /* Updation After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"Select * from todo where id={id} ";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    string task = dt.Rows[0]["task"].ToString();
                    bool isDone = bool.Parse(dt.Rows[0]["isdone"].ToString());
                    DateTime deadline = DateTime.Parse(dt.Rows[0]["deadline"].ToString());

                    string taskData, statusData, dlData;

                    if(taskInput.Text == "")
                    {
                        taskData = task;
                    }
                    else
                    {
                        taskData = taskInput.Text;
                    }
                    if (statusInput.SelectedValue == isDone.ToString())
                    {
                        statusData = isDone.ToString();
                    }
                    else
                    {
                        statusData = statusInput.SelectedValue;
                    }
                    if (dlInput.Text == "")
                    {
                        dlData = deadline.ToString();
                    }
                    else
                    {
                        dlData = dlInput.Text;
                    }
                    cmd.CommandText = $"update todo set task='{taskData}', isdone={statusData},deadline='{dlData}' where id={id}";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    //warning.Text = statusInput.SelectedValue + " ======= " + dlInput.Text + " =========== " + taskInput.Text;

                    Response.Redirect("~/");
                }
            }
            catch (Exception ex) {
                    warning.Text = "gagal";


            }
        }

    }
}
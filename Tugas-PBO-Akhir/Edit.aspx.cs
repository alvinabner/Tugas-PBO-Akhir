using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_PBO_Akhir.Controller;

namespace Tugas_PBO_Akhir
{
    public partial class Edit : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["id"];
                Todo todo = TodoDB.getDataByID(id);
                taskInput.Text = todo.task;
                statusInput.SelectedValue = todo.isDone.ToString();
                dlData.Text = todo.deadline.ToString();
                dlLabel.Text += " (" + todo.deadline.ToString("MM/dd/yyyy HH:mm") +")";

            }


        }




        protected void updateData(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            string id = Request.QueryString["id"];

            string dl;

            if (dlInput.Text == "")
            {
                dl = dlData.Text;
            }
            else
            {
                dl = dlInput.Text;
            }

            data.Add("task", taskInput.Text);
            data.Add("isdone", statusInput.SelectedValue);
            data.Add("deadline", dl);

            var res = TodoDB.updateData(id, data);

            if (res == "berhasil")
            {
                Response.Redirect("~/");

            }
            else
            {
                warning.Text = "gagal";
            }

        }

    }
}
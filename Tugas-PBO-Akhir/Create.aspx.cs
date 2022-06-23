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
    public partial class Create : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insertData(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            data.Add("task", todo.Text);
            data.Add("isdone", status.SelectedValue);
            data.Add("deadline", deadline.Text);

            var res = TodoDB.createData(data);

            if (res == "berhasil")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblmsg.Text = res;
            }

            
        }
    }
}
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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            var res = TodoDB.deleteData(id);

            if (res == "berhasil")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Data Berhasil Dihapus" + "');", true);
                Response.Redirect("~/");
            }
            else
            {
                warning.Text = res;
            }

        }
        
    }
}
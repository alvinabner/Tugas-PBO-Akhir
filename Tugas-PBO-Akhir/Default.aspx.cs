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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Todo> todoList = TodoDB.getAllData();
            int index = 1;
            foreach (Todo todo in todoList)
            {
                var status = (todo.isDone) ? "Finished" : "Unfinished";
                body.InnerHtml += 
                    $"<tr><td class=\"text\" >{index}</td>" +
                    $"<td class=\"text\">{todo.task}</td>" +
                    $"<td class=\"text\">{todo.deadline.ToString("dd-MMM-yyyy  HH:mm")}</td>" +
                    $"<td class=\"text\">{status}</td>" +
                    $"<td class=\"text-center\">" +
                    $"<a class=\"btn btn-primary mr-2 \" href=\"Edit.aspx?id={todo.id}\">Edit</a>" +
                    $"<a class=\"btn btn-danger mr-2 \" href=\"Delete.aspx/?id={todo.id}\">Delete</a></td></tr>";
                index++;
            }
        }

        

        
    }
}
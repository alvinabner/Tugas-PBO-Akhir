using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tugas_PBO_Akhir
{
    public class Todo
    {
        public string id;
        public string task;
        public bool isDone;
        public DateTime deadline;

        public Todo(string id, string task, bool isDone, DateTime deadline)
        {
            this.id = id;
            this.task = task;
            this.isDone = isDone;
            this.deadline = deadline;
        }
    }
}
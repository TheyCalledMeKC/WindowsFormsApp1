using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp1.modal
{
    public class Sheet_Model
    {
        private DateTime time;
        private string category;
        private bool priority;
        private string task;
        public bool done;

        public Sheet_Model() { }
        public Sheet_Model(DateTime date, string category, bool priority, string task, bool done)
        {
            time = date;
            this.category = category;
            this.priority = priority;
            this.task = task;
            this.done = done;
        }
        public void setTime(DateTime time) { this.time = time; }
        public DateTime getTime() { return time; }
        public void setCategory(string category) { this.category = category; }
        public string getCategory() { return category; }
        public void setPriority(bool priority) { this.priority = priority; }
        public bool getPriority() { return priority; }
        public void setTask(string task) { this.task = task; }
        public string getTask() { return task; }
        public void setDone(bool done) { this.done = done; }
        public bool getDone() { return done; }

    }
}

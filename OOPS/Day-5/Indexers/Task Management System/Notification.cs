using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class Notification
    {
        public  void OnTaskCompleted(TaskEntity task)
        {
            Console.WriteLine($"[Notification] Task '{task.Title}' completed by {task.AssignedTo}");
        }
    }
}

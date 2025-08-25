using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            Notification notify = new Notification();
            var task1 = new TaskEntity { Id = 1, Title = "Design LLD", AssignedTo = "Alice", Priority = 7 };
            var task2 = new TaskEntity { Id = 2, Title = "Implement Events", AssignedTo = "Bob", Priority = 4 };
            task1.TaskCompleted += notify.OnTaskCompleted;
            task2.TaskCompleted += notify.OnTaskCompleted;
            manager.AddTask(task1);
            manager.AddTask(task2);

            task1.CompleteTask();

            Console.WriteLine("\nCompleted Tasks:");
            foreach (var t in manager.GetCompletedTasks())
                Console.WriteLine($" - {t.Title}");

            Console.WriteLine("\nPending Tasks:");
            foreach (var t in manager.PendingTasks())
                Console.WriteLine($" - {t.Title}");

            Console.WriteLine("\nHigh Priority Tasks:");
            foreach (var t in manager.GetHighPriority())
                Console.WriteLine($" - {t.Title} (Priority {t.Priority})");

            Console.ReadLine();
        }
    }
}

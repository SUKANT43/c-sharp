using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class TaskManager
    {
        private List<TaskEntity> tasks = new List<TaskEntity>();

        public void AddTask(TaskEntity task)
        {
            tasks.Add(task);
        }
        public IEnumerable<TaskEntity> GetAllTasks()
        {
            return tasks;
        }

        public IEnumerable<TaskEntity> GetCompletedTasks()
        {
            return tasks.Where(t => t.IsCompleted);
        }
        
        public IEnumerable<TaskEntity> PendingTasks()
        {
            return tasks.Where(t => !t.IsCompleted);
        }

        public IEnumerable<TaskEntity> GetHighPriority()
        {
            return tasks.Where(t => t.priority > 5);
        }
    }
}

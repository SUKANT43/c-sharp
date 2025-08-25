using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AssignedTo { get; set; }
        public bool IsCompleted { get; private set; }
        public int priority;

        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }

        public event Action<TaskEntity> TaskCompleted;

        public void CompleteTask()
        {
            IsCompleted = true;
            TaskCompleted?.Invoke(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent4
{
    public delegate void DoorEventHandler();
    class SecuritySystem
    {
        public event DoorEventHandler DoorOperation;
        public void verifyUser()
        {
            Console.WriteLine("Verifying user Id...");
            Console.WriteLine("User verified!");
            DoorOperation?.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent4
{
    class Program
    {
        static void OpenDoor(string id)
        {
            Console.WriteLine("Door is now OPEN "+id);
        }

        static void CloseDoor(string id)
        {
            Console.WriteLine("Door is now CLOSED "+id);
        }

        static void Main(string[] args)
        {
            SecuritySystem system = new SecuritySystem();
            system.DoorOperation += OpenDoor;
            system.DoorOperation += CloseDoor;
            system.verifyUser("EC326");
            //SecuritySystem system2 = null;
            //system2.DoorOperation += OpenDoor;
            //system2.DoorOperation += CloseDoor;
            //system2.verifyUser();
            Console.ReadLine();
        }
    }
}

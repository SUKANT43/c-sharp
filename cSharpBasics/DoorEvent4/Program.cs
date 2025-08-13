using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent4
{
    class Program
    {
        static void OpenDoor()
        {
            Console.WriteLine("Door is now OPEN.");
        }

        static void CloseDoor()
        {
            Console.WriteLine("Door is now CLOSED.");
        }

        static void Main(string[] args)
        {
            SecuritySystem system = new SecuritySystem();
            system.DoorOperation += OpenDoor;
            system.DoorOperation += CloseDoor;
            system.verifyUser();
           // SecuritySystem system2 = null;
            //system2.DoorOperation += OpenDoor;
            //system2.DoorOperation += CloseDoor;
            //system2.verifyUser();
            Console.ReadLine();
        }
    }
}

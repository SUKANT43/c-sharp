using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class Program
    {
        static void Main(string[] args)
        {
            Access acc = new Access();
            OpenDoor open = new OpenDoor(acc);
            CloseDoor close = new CloseDoor(acc);
            acc.newPerson();
            Console.ReadLine();
        } 
    }
}

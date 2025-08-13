using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class Program
    {
        static void Main(string[] args)
        {
            Access acc = new Access();
            OpenDoor open = new OpenDoor(acc);
            DoorClose close = new DoorClose(acc);
            acc.AccessForThePerson();
            Console.ReadLine();
        }
    }
}

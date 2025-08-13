using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    class CloseDoor
    {
        public Access close;
        public CloseDoor(Access close)
        {
            this.close = close;
            close.AllowThePerson += AccessCloseDoor;
        }
        public void AccessCloseDoor()
        {
            Console.WriteLine("Door Closed");
        }
    }
}

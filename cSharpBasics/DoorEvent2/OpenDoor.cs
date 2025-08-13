using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class OpenDoor
    {
        public Access acc;

        public OpenDoor(Access acc)
        {
            this.acc = acc;
            acc.GiveAccess += AccessOpenDoor;
        }
        public void AccessOpenDoor(Object e,EventArgs a)
        {
            Console.WriteLine("Door Open 2");
        }
    }
}

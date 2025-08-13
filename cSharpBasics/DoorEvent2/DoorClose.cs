using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class DoorClose
    {
       public Access acc;
        public DoorClose(Access acc)
        {
            this.acc = acc;
            acc.GiveAccess += AccessDoorClose;
        }
        public void AccessDoorClose(object e, EventArgs a)
        {
            Console.WriteLine("Door closed 2");
        }
    }
}

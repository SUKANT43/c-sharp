using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class CloseDoor
    {
        public Access acc;
        public CloseDoor(Access acc)
        {
            this.acc = acc;
            acc.giveAccess += CloseTheDoor;
        }
        public void CloseTheDoor(object e,userDetails details)
        {
            Console.WriteLine("Close the door for" +"Id "+ details.id +" and "+details.name);
        }
    }
}

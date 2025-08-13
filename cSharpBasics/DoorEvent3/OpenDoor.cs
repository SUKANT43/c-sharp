using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class OpenDoor
    {
        public Access acc;
        public OpenDoor(Access acc)
        {
            this.acc = acc;
            acc.giveAccess += OpenTheDoor;
        }
        public void OpenTheDoor(object e,userDetails details)
        {
            Console.WriteLine("Open the door for" + "Id " + details.id + " and " + details.name);
        }
    }
}

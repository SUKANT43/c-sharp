using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    class OpenDoor
    {
        public Access GiveAccess;
        public OpenDoor(Access GiveAccess)
        {
            this.GiveAccess = GiveAccess;
            GiveAccess.AllowThePerson += OpenDoorAccess;
        }
        public void OpenDoorAccess()
        {
            Console.WriteLine("Door opened");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DoorEvent
{
    class Access
    {
        public delegate void GiveAccess();
        public event GiveAccess AllowThePerson;
        public void Allow()
        {
            AllowThePerson?.Invoke();
        }
    }
}

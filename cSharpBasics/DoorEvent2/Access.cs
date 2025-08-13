using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class Access
    {
        public event EventHandler GiveAccess;
        public void AccessForThePerson()
        {
            GiveAccess?.Invoke(this,null);
        }
    }
}

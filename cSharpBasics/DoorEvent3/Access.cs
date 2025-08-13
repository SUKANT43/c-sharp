using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class userDetails:EventArgs
    {
       public string name { get; set; }
       public string id { get; set; }
    }

    class Access
    {
        public event EventHandler<userDetails> giveAccess;

        public void newPerson()
        {
            userDetails details = new userDetails { name = "Sukant C", id = "EC326" };
            giveAccess?. Invoke(this,details);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{

    public delegate void Notify(string message);
    class Disp2
    {
        public event Notify OnNotify;
        public  void disp2()
        {
            Console.WriteLine("do some work....");
            OnNotify?.Invoke("Work  Completed!");
        }
    }
}

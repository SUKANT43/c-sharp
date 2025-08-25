using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{

    delegate void MyDelegate(string msg);
    class Disp1
    {
        public static void msg(string ms)
        {
            Console.WriteLine(ms);
        }
        public static void msg2(string ms)
        {
            Console.WriteLine(ms);
        }


        public static void disp1()
        {
            MyDelegate del = msg;
            del += msg2;//multi casting
            del("hi");
            del("hello");
        }
    }
}

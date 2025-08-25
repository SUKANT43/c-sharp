using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class MyChar
    {
        private char ch;
        public MyChar(char ch)
        {
            this.ch = ch;
        }

        public static bool operator ==(MyChar c1,MyChar c2)
        {
            return c1.ch == c2.ch;
        }

        public static bool operator !=(MyChar c1,MyChar c2)
        {
            return c1.ch != c2.ch;
        }

    }

    class Disp
    {
        public static void disp()
        {
            MyChar c1 = new MyChar('a');
            MyChar c2 = new MyChar('a');
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);
        }
    }
}

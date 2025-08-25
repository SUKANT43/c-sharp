using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MySolution
    {
        int[] arr = new int[5];

        public int this[int num]
        {
            set
            {
                arr[num] = value;
            }
            get
            {
                return arr[num];
            }
        }
    }
    class Disp1
    {
        public static void disp1()
        {
            MySolution sol = new MySolution();
            sol[0] = 10;
            sol[1] = 100;
            Console.WriteLine(sol[0]);
        }
    }
}

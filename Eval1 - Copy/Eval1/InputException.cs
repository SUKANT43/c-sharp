using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1
{
    class InputException:Exception
    {
        public InputException(string st)
        {
            Console.WriteLine(st);
        }
    }
}

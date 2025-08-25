using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class EmployeeDictionary
    {
     private Dictionary<string ,string>emp=new Dictionary<string,string>();
        public string this[string id]
        {
            set
            {
                emp[id] = value;
            }
            get
            {
                if (emp.ContainsKey(id))
                {
                    return emp[id];
                }
                return "Emp not found";
            }
        }
    }

    class Disp2
    {
        public static void disp2()
        {
            EmployeeDictionary emp = new EmployeeDictionary();
            emp["ec340"] = "vijay";
            emp["ec326"] = "sukant";
            Console.WriteLine(emp["ec326"]);
            Console.WriteLine(emp["ec341"]);

        }
    }
}

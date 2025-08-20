using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    class Account
    {
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Account details from the base class");
        }
    }

    class SavingsAccount : Account
    {
        public override void DisplayDetails()
        {
            Console.WriteLine("Account details from the SavingsAcoount");
        }
    }

    class CurrentAccount : Account
    {
        public override void DisplayDetails()
        {
            Console.WriteLine("Account details from the CurrentAccount");
        }
    }

    class Disp3
    {
        public static void disp3()
        {
            Account ac = new SavingsAccount();
            ac.DisplayDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    sealed class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment processed successfully.");
        }
    }

    class M1
    {
        public virtual void Print()
        {
            Console.WriteLine("Non sealed methods.");
        }
    }

    class M2:M1
    {
        public sealed override void Print()
        {
            base.Print();
        }
    }

    class M3 : M2
    {
       /* public override void Print()
        {
            base.Print();
        }*/
    }

    class Disp5
    {
        public static void disp5()
        {
            Payment p = new Payment();
            p.MakePayment();

            M1 m = new M1();
            m.Print();
            M2 m2 = new M2();
            m2.Print();
        }
    }
}

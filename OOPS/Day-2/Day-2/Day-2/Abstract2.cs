using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    abstract class Animal2
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    abstract class Mammal : Animal2
    {
        public abstract void Walk();
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }

    class Dog2 : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof!");

        }

        public override void Walk()
        {
            Console.WriteLine("Dog is walking on four legs.");
        }
    }

    class Disp7
    {
        public static void disp7()
        {
            Dog2 d = new Dog2();
            d.MakeSound();
            d.Walk();
            d.Sleep();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Disp6
    {
        public static void disp6() {
            Animal dog = new Dog();
            dog.MakeSound(); 
            dog.Sleep();     

            Animal cat = new Cat();
            cat.MakeSound(); 
            cat.Sleep();     

        }
    }
}

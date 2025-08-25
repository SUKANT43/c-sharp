using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        class InvalidAgeException : Exception
        {
            public InvalidAgeException(string msg) : base(msg) { }
        }
        static void Main(string[] args)
        {
            try
            {
                int age = 16;
                if (age <= 18)
                {
                    throw new InvalidAgeException("Age must 18 or above");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}

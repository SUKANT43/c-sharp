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
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                int a = arr[8];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);        
            }

            try
            {
                int num = int.Parse("jhfb");
                string a = null;
                Console.WriteLine(a);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int x = 10;
                int y = 0;
                int res =x / y;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}

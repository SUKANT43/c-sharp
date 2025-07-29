using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalcLib;

namespace Calculator1
{
    class Program
    {
        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static int Solution(int result)
        {
            Console.WriteLine("Your Answer: " + result);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to Add, 2 to Subract , 3 to Multiply, 4 to Division , 5 to Modulus and -1 to exit: ");
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            if (choice > 5 || choice < 1)
            {
                Console.WriteLine("Choose the given choice only.");
                Console.ReadLine();
                return;
            }
            Console.Write("Enter Number a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number b:");
            int b = int.Parse(Console.ReadLine());
            while (choice != -1)
            {
                switch (choice)
                {
                    case 1:
                        a = Solution(Calc.Add(a, b));
                        break;

                    case 2:
                        a = Solution(Calc.Subract(a, b));
                        break;

                    case 3:

                        a = Solution(Calc.Multiply(a, b));
                        break;

                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            Console.ReadLine();
                            return;
                        }
                        a = Solution(Calc.Division(a, b));
                        break;
                   

                }
                Console.WriteLine("Enter 1 to Add, 2 to Subract , 3 to Multiply, 4 to Division,  5 to Modulus and -1 to exit: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == -1 || choice < -1 || choice == 0 || choice > 5)
                {
                    return;
                }
                Console.WriteLine("Enter Number to operate with previous answer: ");
                b = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}

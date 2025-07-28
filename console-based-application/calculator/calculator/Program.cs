using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {

        public static void Solution(int result)
        {
            Console.WriteLine("Your Answer: "+ result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to Add, 2 to Subract , 3 to Multiply, 4 to Division");
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            if (choice > 4 || choice < 1)
            {
                Console.WriteLine("Choose the given choice.");
                Console.ReadLine();
                return;
            }
            Console.Write("Enter Number a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number b:");
            int b = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Solution(Calculator.Add(a, b));
            }
            else if (choice == 2)
            {
                Solution(Calculator.Subract(a, b));
            }
            else if (choice == 3)
            {
                Solution(Calculator.Multiply(a, b));
            }
            else if (choice == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    Console.ReadLine();
                    return;
                }
                    Solution(Calculator.Division(a, b));
            }
            Console.ReadLine();
        }

    }
}

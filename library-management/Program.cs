using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\nWelcome to the Library Management System Application!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Login as Admin");
            Console.WriteLine("2. View Books (User)");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                continue;
            }

            if (choice == 1)
            {
                AdminLogin();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Welcome User! Here are the available books:");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you for using the Library Management System. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }
    }
}

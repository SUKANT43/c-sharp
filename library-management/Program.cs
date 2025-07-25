using System;

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
            Console.WriteLine("2. View & Borrow Books (User)");
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
                UserMenu();
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

    static void AdminLogin()
    {
        Console.Write("\nEnter Admin Username: ");
        string adminName = Console.ReadLine();
        Console.Write("Enter Admin Password: ");
        string adminPass = Console.ReadLine();

        if (Admin.Authenticate(adminName, adminPass))
        {
            AdminMenu();
        }
        else
        {
            Console.WriteLine("Returning to main menu...");
        }
    }

    static void AdminMenu()
    {
        string adminChoice = "";
        while (adminChoice != "d")
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("a. Add Book");
            Console.WriteLine("b. Remove Book");
            Console.WriteLine("c. View Books");
            Console.WriteLine("d. Logout");
            Console.Write("Enter your choice: ");
            adminChoice = Console.ReadLine().ToLower();

            switch (adminChoice)
            {
                case "a":
                    Console.Write("Enter Book ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Book Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Book Stock: ");
                    int stock = int.Parse(Console.ReadLine());

                    ManageBook.AddBook(id, title, author, stock);
                    break;

                case "b":
                    Console.Write("Enter Book ID to remove: ");
                    int removeId = int.Parse(Console.ReadLine());
                    ManageBook.RemoveBook(removeId);
                    break;

                case "c":
                    ManageBook.ViewBooks();
                    break;

                case "d":
                    Console.WriteLine("Logging out...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void UserMenu()
    {
        int userChoice = 0;
        while (userChoice != 2)
        {
            Console.WriteLine("\n--- User Menu ---");
            Console.WriteLine("1. View Available Books");
            Console.WriteLine("2. Return to Main Menu");
            Console.WriteLine("3. Borrow a Book");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (userChoice)
            {
                case 1:
                    ManageBook.ViewBooks();
                    break;

                case 3:
                    Console.Write("Enter the Book ID to borrow: ");
                    int borrowId = int.Parse(Console.ReadLine());
                    ManageBook.UpdateBookStock(borrowId);
                    break;

                case 2:
                    Console.WriteLine("Returning to Main Menu...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}

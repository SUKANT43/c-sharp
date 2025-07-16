public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 to access the admin section or 2 to access the user section. Enter 3 to exit.");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());
        while (choice != -1)
        {
            if (choice == 1)
            {
                Console.WriteLine("You have chosen to access the admin section for access you need to enter the UserName and Password.");

                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    
                }
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2. Try again.");
            }
        }

    }
} 
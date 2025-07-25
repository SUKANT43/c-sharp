public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Library Management System Application! please choose a Option: ");
        Console.WriteLine("1. Login as a Admin");
        Console.WriteLine("2. Login as a User");
        Console.WriteLine("3. Exit");

        int Choice = int.Parse(Console.ReadLine());

        while (Choice != 3)
        {
            while (Choice == 1)
            {
                Console.WriteLine("You have chosen to login as an Admin.");
                Console.Write("Enter Admin Username: ");
                string adminName = Console.ReadLine();
                Console.Write("Enter Admin Password: ");
                string adminPass = Console.ReadLine();
                if (Admin.Authenticate(adminName, adminPass))
                {
                    Console.WriteLine("Admin login successful!");
                }
                else
                {
                    Console.WriteLine("Admin login failed. Please try again.");
                    Console.Write("Try again 1 for Admin , 2 for User, 3 to Exit: ");
                    Choice = int.Parse(Console.ReadLine());
                }
            }
        }

        Console.WriteLine("Thank you for using the Library Management System Application. Goodbye!");     
    }
}
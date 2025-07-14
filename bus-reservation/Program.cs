using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        ArrayList buses = new ArrayList();

        buses.Add(new Bus(101, true, 5));
        buses.Add(new Bus(102, false, 4));
        buses.Add(new Bus(103, true, 6));

        Console.WriteLine();
        Console.WriteLine("Available Buses:");
        Console.WriteLine("---------------");


        foreach (Bus bus in buses)
        {
            bus.displayBusInfo();
        }
        Console.WriteLine();

        int userOpt = 1;
        while (userOpt != 2)
        {
            Console.WriteLine("Enter 1 to Book and 2 to exit:");
            userOpt = int.Parse(Console.ReadLine());
            if (userOpt == 1)
            {
                Console.WriteLine("Booking a bus...");
            }
        }

        


    }
}
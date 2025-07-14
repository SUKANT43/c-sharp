using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        ArrayList buses = new ArrayList();
        ArrayList bookings = new ArrayList();

        buses.Add(new Bus(101, true, 2));
        buses.Add(new Bus(102, false, 3));
        buses.Add(new Bus(103, true, 1));

        Console.WriteLine("\nAvailable Buses:");
        foreach (Bus bus in buses)
        {
            bus.displayBusInfo();
        }

        int userOpt = 1;

        while (userOpt != -1)
        {
            Console.WriteLine("\nEnter 1 to Book, 2 to View Bus Details, 3 to Exit:");
            userOpt = int.Parse(Console.ReadLine()!);

            if (userOpt == 1)
            {
                Booking booking = new Booking();

                if (booking.isAvailable(bookings, buses))
                {
                    bookings.Add(booking);
                    Console.WriteLine("Booking successful for " + booking.PassengerName);
                }
                else
                {
                    Console.WriteLine("Sorry, no available seats on this bus.");
                }
            }
            else if (userOpt == 2)
            {
                Console.WriteLine("\nAvailable Buses:");
                foreach (Bus bus in buses)
                {
                    bus.displayBusInfo();
                }
            }
            else if (userOpt == 3)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}

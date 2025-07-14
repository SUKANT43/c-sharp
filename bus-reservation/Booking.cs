using System;
using System.Collections;

public class Booking
{
    public string PassengerName;
    public int BusNo;
    public DateTime BookingDate;

    public Booking()
    {
        Console.WriteLine("Enter Passenger Name:");
        PassengerName = Console.ReadLine()!;
        Console.WriteLine("Enter Bus No:");
        BusNo = int.Parse(Console.ReadLine()!);
        BookingDate = DateTime.Now;
    }

public bool isAvailable(ArrayList bookings, ArrayList buses)
{
    foreach (Bus bus in buses)
    {
        if (bus.getBusNo() == BusNo)
        {
            if (bus.getCapacity() > 0)
            {
                bus.setCapacity(bus.getCapacity() - 1);
                return true;
            }
            else
            {
                return false; 
            }
        }
    }

    return false; 
}
}

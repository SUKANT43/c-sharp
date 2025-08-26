using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Service.TaxiManagement.NumberOfTaxis(4);
            Service.TaxiManagement.GetTaxiDetails();
            Console.WriteLine("Enter 1 for booking and -1 for cancel");
            int book = 1;
            while (book != -1) { 
                int customerId= int.Parse(Console.ReadLine());
                string PickUpPoint = Console.ReadLine();
                string DropPoint = Console.ReadLine();
                int PickUpTime = int.Parse(Console.ReadLine());
                Service.TaxiManagement.AllocateTaxiToTheCustomer(customerId,PickUpPoint,DropPoint,PickUpTime);
                Service.TaxiManagement.GetTaxiDetails();
                Console.WriteLine("Enter 1 for booking and -1 for cancel");
                book = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}

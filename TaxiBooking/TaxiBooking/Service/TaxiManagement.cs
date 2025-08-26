using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBooking.Service
{
    class BookingId
    {
        public static int id=1;
        
       public BookingId()
        {
            id++;
        }
    }
    class TaxiManagement
    {
       static List<Models.Taxi> TaxiList = new List<Models.Taxi>(); 
        public static void NumberOfTaxis(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                TaxiList.Add(new Models.Taxi { TaxiId = i, CurrentLocation = "A", DropLocation = null, PickUpTime = 0, DropTime=0, TotalAmount=0 });
            }
        }

       public static void GetTaxiDetails()
        {
            foreach(var tx in TaxiList)
            {
                Console.WriteLine($"Taxi Id: {tx.TaxiId} , Current Location: {tx.CurrentLocation} , DropLocation: {tx.DropLocation} , PickUpTime: {tx.PickUpTime} , DropTime: {tx.DropTime} , Total Amount:{tx.TotalAmount}");
            }
        }


        public static void AllocateTaxiToTheCustomer(int CustomerId,string PickUpPoint, string DropPoint, int PickUpTime)
        {
            bool check = true;
            //same location search
            foreach(var tx in TaxiList)
            {
                if((tx.DropLocation==null||tx.DropTime>=PickUpTime) && (tx.CurrentLocation==PickUpPoint||tx.DropLocation==PickUpPoint))
                {
                    check = false;
                    tx.CurrentLocation = PickUpPoint;
                    tx.DropLocation = DropPoint;
                    tx.PickUpTime = PickUpTime;
                    int a = PickUpPoint[0]-'0';
                    int b = DropPoint[0] - '0';
                    tx.DropTime = (a - b) * 100;
                    break;
                }
            }
        }
    }
}


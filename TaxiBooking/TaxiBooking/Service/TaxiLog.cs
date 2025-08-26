using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBooking.Service
{
    class TaxiLog
    {
        static List<Models.TaxiDetails> TaxiLogs = new List<Models.TaxiDetails>();

        public static void AddLog(int TaxiId,int BookingId,int CustomerId,string From, string To, int PickupTime,int DropTime,int Amount)
        {

        }
    }
}
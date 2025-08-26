using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBooking.Models
{
    class TaxiDetails
    {
        public int TaxiId { get ; set; }
        public static int BookingId { get; set; }
        public int CustomerId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int PickupTime { get; set; }
        public int DropTime { get; set; }
        public int Amount { get; set; }
    }

}

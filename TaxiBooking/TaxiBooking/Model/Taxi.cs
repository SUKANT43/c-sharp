using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBooking.Models
{
    class Taxi
    {
        public int TaxiId { get; set; }
        public string CurrentLocation { get; set; }
        public string DropLocation { get; set; }
        public int PickUpTime { get; set; }
        public int DropTime { get; set; }
        public int TotalAmount { get; set; }
    }
}

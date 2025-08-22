using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Ticket
    {
        public int DurationInHours{ set; get; }
        public DateTime CreationDone { get; set; }
        public Ticket(int DurationInHours)
        {
            this.DurationInHours = DurationInHours;
            this.CreationDone = DateTime.Now;
        }

        public static Ticket operator+(Ticket a,Ticket b)
        {
            return new Ticket(a.DurationInHours + b.DurationInHours);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Ticket firstTicket = new Ticket(3);
            Ticket secondtTicket = new Ticket(4);

            Ticket sumTicket = firstTicket + secondtTicket;
            Console.WriteLine(sumTicket.DurationInHours);
            Disp.disp();
            Console.ReadLine();
        }
    }
}

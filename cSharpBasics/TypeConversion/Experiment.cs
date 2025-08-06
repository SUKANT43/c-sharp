using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Experiment
    {
        public static void display()
        {
            string[] fruits =
            {
                "Apple","Banana","WaterMellon","Kiwi","JackFruit","Orange"
            };

            switch (fruits.Length)
            {
                case 6:
                    Console.Write("6");
                    break;
                case 4:
                    Console.Write("4");
                    break;
                default:
                    Console.Write("done");
                    break
            }
        }
    }
}

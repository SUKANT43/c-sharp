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
            Console.WriteLine("Switch Case");
            switch (fruits.Length)
            {
                case 6:
                    Console.WriteLine("6");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("done");
                    break;
            }

            Console.WriteLine("For loop");

            for(int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i]+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < fruits.Length; ++i)
            {
                Console.Write(fruits[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("ForEach Loop");
            foreach(string a in fruits)
            {
                Console.Write(a + " ");
            }

        }
    }
}

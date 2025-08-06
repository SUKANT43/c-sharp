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

            Console.WriteLine();
            Console.WriteLine("While Loop");

            int j = 0;
            while (j < fruits.Length)
            {
                Console.Write(fruits[j]+" ");
                j++;
            }

            Console.WriteLine();
            j = 0;

            while (j < fruits.Length)
            {
                Console.Write(fruits[j]+" ");
                ++j;
            }

            j = 0;
            Console.WriteLine();
            while (j < fruits.Length-1)
            {
                j++;
                Console.Write(fruits[j]+" ");
            }

            j = 0;
            Console.WriteLine();
            while (j < fruits.Length-1)
            {
                ++j;
                Console.Write(fruits[j]+" ");
            }

            Console.WriteLine();
            Console.WriteLine("Do While Loop");
            j = 0;
            do
            {
                Console.Write(fruits[j] + " ");
                j++;
            } while (j < fruits.Length);
            Console.WriteLine();

            j = 0;
            do
            {
                Console.Write(fruits[j] + " ");
                ++j;
            } while (j < fruits.Length);

            Console.WriteLine();

            j = 0;
            do
            {
                j++;
                Console.Write(fruits[j] + " ");
            } while (j < fruits.Length-1);


            Console.WriteLine();

            j = 0;
            do
            {
                ++j;
                Console.Write(fruits[j] + " ");
            } while (j < fruits.Length-1);

        }
    }
}

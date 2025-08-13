using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Deleg
    {
        public delegate void printDelegate(string text);
        public static void ConnectToDataBase(printDelegate log)
        {
            log("Inserting a new record into the database...");
            log("The record got inserted into the database.");
        }
        public static void display()
        {
       
        printDelegate print = (string text) =>
        {
            Console.WriteLine(text);
        };

            printDelegate PrintToFile = (string text) =>
              {
                  try
                  {
                      File.AppendAllText("/logs.txt", text);

                  }
                  catch (Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }
              };
            ConnectToDataBase(print);

          
            PrintToFile("hello hi");
            print("hello hi");
            Deleg.display2();
        }

        public static void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public static void sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }

        public delegate void Math(int a, int b);
        public static void display2()
        {
            Console.WriteLine("Delegate Type 2:");
            Math a = add;
            a(2, 3);
            a(5, 6);
            Math b = sub;
            b(5, 2);
            b(2, 2);

        }

    }
}

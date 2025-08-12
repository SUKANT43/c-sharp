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
        }

    }
}

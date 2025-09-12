using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1
{
    class Program
    {
         public static List<Models.Shapes>data = new List<Models.Shapes>();

        public static void Operation()
        {
            Console.WriteLine("Press 1 to Add Shapes");
            Console.WriteLine("Press 2 to  List All Shapes");
            Console.WriteLine("Press 3 to view Show Shape Details");
            Console.WriteLine("Press 4 to get highest value from all the shapes and colors");
            Console.WriteLine("Press Options:");
            string opt = Console.ReadLine();
            if (opt == "1")
            {
                Console.WriteLine("Press 1 for circle, 2 for Rectangle, 3 for Square, 4 for Triangle");
                Console.WriteLine("Enter Oprions:");
                string shapeOperation = Console.ReadLine();
                double a;
                if (shapeOperation == "1")
                {
                    try
                    {
                        Console.WriteLine("Enter the radius Value:");
                         a= double.Parse(Console.ReadLine());
                        if (a < 0)
                        {
                            throw new Exception("Dont enter negative value.");
                        }

                    }
                    catch(Exception e)
                    {
                        throw new InputException("Enter only Double. "+e);
                    }
                    Models.Circle cr = new Models.Circle();
                    cr.DataVal(a);
                    cr.CalculateArea();
                    cr.CalculatePerimeter();
                    
                }
                if (shapeOperation == "2")
                {
                    double l, b;
                    try
                    {
                        Console.WriteLine("Enter the length Value");
                         l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breadth Value");
                         b = double.Parse(Console.ReadLine());
                        if (l < 0 || l < 0)
                        {

                            throw new Exception("Dont enter negative value.");

                        }
                    }
                    catch (Exception e)
                    {
                        throw new InputException("Enter only Double. " + e);
                    }


                    Models.Rectangle cr = new Models.Rectangle();
                    cr.DataVal(l,b);
                    cr.CalculateArea();
                    cr.CalculatePerimeter();
                }
                if (shapeOperation == "3")
                {
                    Console.WriteLine("Enter the Side Value");
                    double s = double.Parse(Console.ReadLine());

                    Models.Square cr = new Models.Square();
                    cr.DataVal(s);
                    cr.CalculateArea();
                    cr.CalculatePerimeter();
                }
                if (shapeOperation == "4")
                {
                    Console.WriteLine("Enter the side1 Value");
                    double s1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the side2 Value");
                    double s2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the side3 Value");
                    double s3 = double.Parse(Console.ReadLine());

                    Models.Triangle cr = new Models.Triangle();
                    cr.DataVal(s1,s2,s3);
                    cr.CalculateArea();
                    cr.CalculatePerimeter();
                }
            }
            if (opt == "2")
            {
                Console.WriteLine("Square");
                Console.WriteLine("Triangle");
                Console.WriteLine("Rectangle");
                Console.WriteLine("Circle");
            }
            if (opt == "3")
            {
                foreach(var d in data)
                {
                     Console.WriteLine($"Shape Name: {d.shapeName}, Color: {d.color}, Values: {d.val}");
                }
            }
            if (opt == "4")
            {
                Console.WriteLine("Press 1 to view Area and press any key to view Perimeter");
                string op = Console.ReadLine();
                if (op == "1")
                {
                    var info = data.Where(d => d.color == "Area").OrderBy(d => d.val);

                    foreach (var d in info)
                    {
                        Console.WriteLine($"Shape Name: {d.shapeName}, Color: {d.color}, Values: {d.val}");
                    }
                }
                else
                {
                    var info = data.Where(d => d.color=="Perimter").OrderBy(d => d.val);
                    foreach (var d in info)
                    {
                        Console.WriteLine($"Shape Name: {d.shapeName}, Color: {d.color}, Values: {d.val}");
                    }
                }
            }
           
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Press any key to Continue or press 5 to exit:");
            string option = Console.ReadLine();
            while (option != "5")
            {
                Operation();
                Console.WriteLine("Press any key to Continue or press 5 to exit:");
                option = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

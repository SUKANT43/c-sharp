using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeManagerApp
{
    // ===============================
    // 1. Abstract Base Class: Shape
    // ===============================
    public abstract class Shape
    {
        public string ShapeName { get; set; }
        public string Color { get; set; }

        public Shape(string shapeName, string color)
        {
            ShapeName = shapeName;
            Color = color;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape: {ShapeName}, Color: {Color}");
        }
    }

    // ===============================
    // 2. Derived Classes
    // ===============================

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color) : base("Circle", color)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive.");
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Radius * Radius;
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public double Diameter => 2 * Radius;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Radius: {Radius}, Diameter: {Diameter:F2}, Area: {CalculateArea():F2}, Perimeter: {CalculatePerimeter():F2}");
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, string color) : base("Rectangle", color)
        {
            if (length <= 0 || width <= 0) throw new ArgumentException("Length and Width must be positive.");
            Length = length;
            Width = width;
        }

        public override double CalculateArea() => Length * Width;
        public override double CalculatePerimeter() => 2 * (Length + Width);

        public double Diagonal => Math.Sqrt(Length * Length + Width * Width);

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Length: {Length}, Width: {Width}, Diagonal: {Diagonal:F2}, Area: {CalculateArea():F2}, Perimeter: {CalculatePerimeter():F2}");
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, string color) : base("Square", color)
        {
            if (side <= 0) throw new ArgumentException("Side must be positive.");
            Side = side;
        }

        public override double CalculateArea() => Side * Side;
        public override double CalculatePerimeter() => 4 * Side;

        public double Diagonal => Math.Sqrt(2) * Side;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Side: {Side}, Diagonal: {Diagonal:F2}, Area: {CalculateArea():F2}, Perimeter: {CalculatePerimeter():F2}");
        }
    }

    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c, string color) : base("Triangle", color)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Sides must be positive.");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Invalid triangle sides.");
            SideA = a; SideB = b; SideC = c;
        }

        public override double CalculatePerimeter() => SideA + SideB + SideC;

        public override double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string TriangleType
        {
            get
            {
                if (SideA == SideB && SideB == SideC) return "Equilateral";
                else if (SideA == SideB || SideB == SideC || SideA == SideC) return "Isosceles";
                else return "Scalene";
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sides: {SideA}, {SideB}, {SideC}, Type: {TriangleType}, Area: {CalculateArea():F2}, Perimeter: {CalculatePerimeter():F2}");
        }
    }

    // ===============================
    // 3. Shape Manager
    // ===============================
    public class ShapeManager
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            // Prevent duplicate (same type + dimensions)
            if (shapes.Any(s => s.GetType() == shape.GetType() &&
                                Math.Abs(s.CalculateArea() - shape.CalculateArea()) < 0.0001))
            {
                Console.WriteLine("Duplicate shape not allowed.");
                return;
            }
            shapes.Add(shape);
            Console.WriteLine($"{shape.ShapeName} added successfully!");
        }

        public void ListShapes()
        {
            if (!shapes.Any())
            {
                Console.WriteLine("No shapes available.");
                return;
            }

            Console.WriteLine("\nList of Shapes:");
            foreach (var shape in shapes)
            {
                shape.DisplayInfo();
                Console.WriteLine("-----------------------------------");
            }
        }

        public void SortByArea()
        {
            shapes = shapes.OrderBy(s => s.CalculateArea()).ToList();
            Console.WriteLine("Shapes sorted by Area.");
        }

        public void SortByPerimeter()
        {
            shapes = shapes.OrderBy(s => s.CalculatePerimeter()).ToList();
            Console.WriteLine("Shapes sorted by Perimeter.");
        }
    }

    // ===============================
    // 4. Program Entry Point (Menu)
    // ===============================
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager manager = new ShapeManager();

            while (true)
            {
                Console.WriteLine("\n=== Shape Manager Menu ===");
                Console.WriteLine("1. Add Shape");
                Console.WriteLine("2. List All Shapes");
                Console.WriteLine("3. Sort by Area");
                Console.WriteLine("4. Sort by Perimeter");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1": AddShapeMenu(manager); break;
                        case "2": manager.ListShapes(); break;
                        case "3": manager.SortByArea(); break;
                        case "4": manager.SortByPerimeter(); break;
                        case "5": return;
                        default: Console.WriteLine("Invalid choice. Try again."); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void AddShapeMenu(ShapeManager manager)
        {
            Console.WriteLine("\nSelect Shape Type:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Square");
            Console.WriteLine("4. Triangle");
            Console.Write("Enter choice: ");

            string typeChoice = Console.ReadLine();
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            try
            {
                switch (typeChoice)
                {
                    case "1":
                        Console.Write("Enter Radius: ");
                        double r = double.Parse(Console.ReadLine());
                        manager.AddShape(new Circle(r, color));
                        break;

                    case "2":
                        Console.Write("Enter Length: ");
                        double l = double.Parse(Console.ReadLine());
                        Console.Write("Enter Width: ");
                        double w = double.Parse(Console.ReadLine());
                        manager.AddShape(new Rectangle(l, w, color));
                        break;

                    case "3":
                        Console.Write("Enter Side: ");
                        double s = double.Parse(Console.ReadLine());
                        manager.AddShape(new Square(s, color));
                        break;

                    case "4":
                        Console.Write("Enter Side A: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Side B: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter Side C: ");
                        double c = double.Parse(Console.ReadLine());
                        manager.AddShape(new Triangle(a, b, c, color));
                        break;

                    default:
                        Console.WriteLine("Invalid shape choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

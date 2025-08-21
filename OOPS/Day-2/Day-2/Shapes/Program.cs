using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    abstract class Shapes
    {
        public abstract void Area();
        public abstract void Perimeter();
    }

    class Square : Shapes
    {
        public int side;
        public Square(int s)
        {
            side = s;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Square: " + (side * side));
        }
        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Square: " +(4*side));
        }
    }

    class Circle : Shapes
    {
        public int radius;
        
        public Circle(int r)
        {
            radius = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Circle: "+(radius*Math.PI*Math.PI));
        }
        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle: " + (radius * Math.PI * 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            c.Area();
            c.Perimeter();
            Square s = new Square(4);
            s.Area();
            s.Perimeter();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1.Models
{
    class Rectangle : Shapes
    {
        public double length;
        public double width;
        public void DataVal(double l, double w)
        {
            length = l;
            width = w;
        }
        public override void CalculateArea()
        {
            double area = length * width;
            
            Program.data.Add(new Rectangle
            {
                shapeName = "Rectangle",
                color = "Area",
                val = area
            });
            Console.WriteLine($"Area :{ area}");


        }
        public override void CalculatePerimeter()
        {
            double perimeter = 2 * (length + width);
            Program.data.Add(new Rectangle
            {
                shapeName = "Rectangle",
                color = "Perimeter",
                val = perimeter
            });
            Console.WriteLine("Perimeter: " + perimeter);

        }
    }
}


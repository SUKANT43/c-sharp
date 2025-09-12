using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1.Models
{
    class Circle:Shapes
    {
        public double radius;

        public void DataVal(double r)
        {
            radius = r;
        }

        
        public override void CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Program.data.Add(new Circle {
                shapeName = "Circle",
                color = "Area",
                val = area
            });
            Console.WriteLine($"Area :{ area}");
        }
        public override void CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI*radius;
            Program.data.Add(new Circle
            {
                shapeName = "Circle",
                color = "Perimeter",
                val = perimeter
            });
            Console.WriteLine("Perimeter: " + perimeter);
        }


    }
}

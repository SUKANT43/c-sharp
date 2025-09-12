using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1.Models
{
    class Square:Shapes
    {
        public double side;
        public void DataVal(double s)
        {
            side = s;
        }
        public override void CalculateArea()
        {
            double area = Math.Pow(side, 2);
            Program.data.Add(new Square
            {
                shapeName = "Square",
                color = "Area",
                val = area
            });
            Console.WriteLine($"Area :{ area}");

        }
        public override void CalculatePerimeter()
        {
            double perimeter = 4 * side;
            Program.data.Add(new Square
            {
                shapeName = "Square",
                color = "Perimeter",
                val = perimeter
            });
            Console.WriteLine("Perimeter: " + perimeter);

        }
    }
}

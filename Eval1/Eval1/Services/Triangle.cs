using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1.Models
{
    class Triangle : Shapes
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public void DataVal(double s1, double s2, double s3)
        {
            sideA=s1;
            sideB = s2;
            sideC = s3;
        }


        public override void CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Program.data.Add(
                new Triangle
                {
                    shapeName = "Triangle",
                    color = "Area",
                    val = area

                });
            Console.WriteLine($"Area :{ area}");
        }
        public override void CalculatePerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            Program.data.Add(new Triangle
            {
                shapeName = "Triangle",
                color = "Perimeter",
                val = perimeter
            });
            Console.WriteLine("Perimeter: " + perimeter);
              
        }
    }
}

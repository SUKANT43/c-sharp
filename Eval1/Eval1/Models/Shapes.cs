using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1.Models
{
    /// <summary>
    /// This Abstract class Shape is a Structure for Shapes
    /// </summary>
    public abstract class Shapes
    {
        public string shapeName { get; set; }
        public string color { get; set; }
        public  double val { get; set; }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
        
    }
}

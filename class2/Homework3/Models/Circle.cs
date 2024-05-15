using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double result = Math.Pow(Radius, 2) * double.Pi;
            return Math.Round(result);
        }

        public override double CalculatePerimeter()
        {
            double result = 2 * Radius * double.Pi;
            return Math.Round(result);

        }
    }
}

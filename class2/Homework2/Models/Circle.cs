using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double result = Math.Pow(Radius, 2) * double.Pi;
            Console.WriteLine($"The area of circe is {Math.Round(result)}");
        }
    }
}

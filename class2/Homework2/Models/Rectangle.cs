using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Models
{
    public class Rectangle : IShape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public void GetArea()
        {
            double result = SideA * SideB;
            Console.WriteLine($"The area of rectange is {Math.Round(result)}");
        }
    }
}

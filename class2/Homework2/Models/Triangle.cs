using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Models
{
    public class Triangle : IShape
    {
        public double BaseA { get; set; }
        public double HightA { get; set; }


        public Triangle(double baseA, double hihgtA)
        {
            BaseA = baseA;
            HightA = hihgtA;

        }
        public void GetArea()
        {
            double result = (BaseA + HightA) / 2;
            Console.WriteLine($"The area of rectange is {Math.Round(result)}");
        }
    }
}

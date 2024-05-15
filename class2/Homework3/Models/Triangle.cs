using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double HightA { get; set; }
       
       
        public Triangle(double sideA, double hihgtA)
        {
            SideA = sideA;
            HightA = hihgtA;
            
        }

        public override double CalculateArea()
        {
            double result = (SideA * HightA)/ 2;
           
            return Math.Round(result);
        }

        public override double CalculatePerimeter()
        {
            double sideB = Math.Sqrt(Math.Pow(HightA, 2) + Math.Pow(SideA / 2, 2));
            double sideC = Math.Sqrt(Math.Pow(HightA, 2) + Math.Pow(sideB, 2));
            double result = SideA + sideC + sideB;

            return Math.Round(result);
        }
    }
}

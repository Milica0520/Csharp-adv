using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int SizeGrams { get; set; }

        public Fish(string name, int age, string color, int size) : base(name, age)
        {
            Color = color;
            SizeGrams = size;
            Type = "Fish";
        }
        public override string  PrintInfo()
        {
            return $"The pets name is {Name}.It is a {Type} and it is {Age} years old. Color : {Color}. Size : {SizeGrams}";
        }
    }
}

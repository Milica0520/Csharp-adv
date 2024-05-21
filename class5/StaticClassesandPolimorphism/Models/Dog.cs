using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesandPolimorphism.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am DOG and i am now eating");
        }
    }
}

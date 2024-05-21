using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesandPolimorphism.Models
{
    public class Cat : Pet
    {
        public bool IzLazy { get; set; }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am cat and i am now eating");
        }

    }
}

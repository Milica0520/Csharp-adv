using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        protected Human(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        public abstract string GetInfo();

        public void Greet(string name)
        {
            Console.WriteLine($"Hey {name}, My fill name is {FullName}");
        }


    }
}

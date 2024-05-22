using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Cat : Pet
    {
        

        public bool Lazy {  get; set; }

        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int lives) : base(name, age)
        {
            Lazy = lazy;
            LivesLeft = lives;
            Type = "Cat";
        }
        public override string PrintInfo()
        {
           return $"The pets name is {Name}.It is a {Type} and it is {Age} years old. " +
                $"Is lazy: {Lazy}. Lifes left {LivesLeft}";
        }
    }
}

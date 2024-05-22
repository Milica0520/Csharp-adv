using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }


        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoy, string favoriteFood) : base(name, age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
            Type = "Dog";
        }


        public override string PrintInfo()
        {
            return $"The pets name is {Name}.It is a {Type} and it is {Age} years old.The dog is good boy : {GoodBoy} and" +
                $"its favorite food is {FavoriteFood}";
        }
    }
}

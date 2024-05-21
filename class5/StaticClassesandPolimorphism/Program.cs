using StaticClassesandPolimorphism.Helpers;
using StaticClassesandPolimorphism.Models;

namespace StaticClassesandPolimorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word1 = "mostar";
            string word2 = "qinshift";
            string word3 = "a";
            string word4 = "";


            string eWord1  = TextHelpers.CapitalFirstLetter(word1);
            string eWord2 = TextHelpers.CapitalFirstLetter(word2);

            Console.WriteLine(eWord1);

            Console.WriteLine($"{TextHelpers.CapitalFirstUsers}");


            string someWord = "alMir";
            //runtime polimorfizam
            Pet dog1 = new Dog();
            dog1.Name = "Rex";

            Pet cat1 = new Cat();
            cat1.Name = "Cile";


            CallEatMethod(dog1);
            CallEatMethod(cat1);


           // PetStatus( );


        }

        //usage of runtime polymorphism//overriding
        public static void CallEatMethod(Pet pet)
        {
            pet.Eat();
        }

        //static polymophism //overloading
        public static void PetStatus(Dog dog, string ownerName)
        {
            Console.WriteLine($"Hi,  {ownerName}");
            if ( dog.IsGoodBoy ) {
                Console.WriteLine($"The dog is a god boy");
            }
            else
            {
                Console.WriteLine($"The dog is not good boy");
            }
        }
        public static void PetStatus( string ownerName, Dog dog,DateTime birth )
        {
            Console.WriteLine($"Hi,  {ownerName}");
            if (dog.IsGoodBoy)
            {
                Console.WriteLine($"The dog is a god boy");
            }
            else
            {
                Console.WriteLine($"The dog is not good boy");
            }
            Console.WriteLine($"The dog birthday is {birth.ToShortDateString()}y");
        }

        public static void PetStatus(Cat cat,string ownerName)
        {
            Console.WriteLine($"Hi,  {ownerName}");
            if (cat.IzLazy)
            {
                Console.WriteLine($"The cat is lazy");
            }
            else
            {
                Console.WriteLine($"The dog is not  blazy.");
            }
           
        }
        public static void PetStatus(Cat cat)
        {
            Console.WriteLine($"NO owner");

            if (cat.IzLazy)
            {
                Console.WriteLine($"The cat is lazy");
            }
            else
            {
                Console.WriteLine($"The dog is not  blazy.");
            }

        }


    }
  
}

using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Utils
{
    public  class PetStore<T> where T : Pet
    {
        public List<T> Pets;

        public  void PrintPets()
        {
            foreach (T pet in Pets)
                Console.WriteLine(pet.PrintInfo());
        }

        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name == name);

            if(pet == null)
            {
                Console.WriteLine("There is no pet with that name.");
            }
            Pets.Remove(pet);

            Console.WriteLine($"Congrats! You bought a pet name {pet.Name}");
        }
       
    }
}

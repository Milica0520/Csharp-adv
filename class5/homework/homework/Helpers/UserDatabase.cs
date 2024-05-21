using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework.Helpers
{
    public static class UserDatabase
    {
       public static List<User> Users { get; set; }
        public static void GetUserById(int id)
        {
           List<User> userById = Users.Where(x => x.Id == id).ToList();
            if(userById.Count == 0) {
                Console.WriteLine($"User by Id {id} not found.");
            }else if (userById.Count == 1)
            {
                Console.WriteLine($"User by Id {id} found. Name: {userById[0].Name}, Age:{userById[0].Age}.");
            }
            else
            {
                Console.WriteLine("Error. Try again.");
            }

        }
        public static void GetUserByName(string name)
        {
            List<User> userByName = Users.Where(x => x.Name.ToLower() == name).ToList();
            if (userByName.Count == 0)
            {
                Console.WriteLine($"User by Name {name} not found");
            }
            else if (userByName.Count == 1)
            {
                Console.WriteLine($"User by Name {name} found. Name: {userByName[0].Name}, Age:{userByName[0].Age}.");
            }
            else if (userByName.Count > 1)
            {
                Console.WriteLine("There is more user with that name. Users are: ");
                foreach (User item in userByName)
                {
                    Console.WriteLine($"User Id:{item.Id}, Name: {item.Name}, Age:{item.Age}");
                }
               
            }
            else
            {
                Console.WriteLine("Error. Try again.");
            }
        }
        public static void GetUserByAge(int age)
        {
            List<User> userByAge = Users.Where(x => x.Age == age).ToList();
            if (userByAge.Count == 0)
            {
                Console.WriteLine($"User by Age {age} not found.");
            }
            else if (userByAge.Count == 1)
            {
                Console.WriteLine($"User by Age {age} found. Name: {userByAge[0].Name}, Age:{userByAge[0].Age}.");
            }
            else if (userByAge.Count > 1)
            {

                Console.WriteLine("There is more users with that age. Users are: ");
                foreach (User item in userByAge)
                {
                    Console.WriteLine($"User Id:{item.Id}, Name: {item.Name}, Age:{item.Age}");
                }
            }
            else
            {
                Console.WriteLine("Error. Try again.");
            }

        }
       
    }
   
}

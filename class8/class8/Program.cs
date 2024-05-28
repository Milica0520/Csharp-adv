using class8.Models;
using System;
using System.Collections.Frozen;

namespace class8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Linq recap

            List<Person> personList = new List<Person>
            {
                new Person { FirstName = "Alice", LastName = "Smith", Age = 25, Country = "USA", Hobbies = new List<string> { "Reading", "Hiking" } },
                new Person { FirstName = "Bob", LastName = "Johnson", Age = 30, Country = "Canada", Hobbies = new List<string> { "Cooking", "Painting" } },
                new Person { FirstName = "Charlie", LastName = "Brown", Age = 22, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "David", LastName = "Wilson", Age = 27, Country = "USA", Hobbies = new List<string> { "Photography", "Gardening" } },
                new Person { FirstName = "Emily", LastName = "Davis", Age = 28, Country = "Canada", Hobbies = new List<string> { "Traveling", "Yoga" } },
                new Person { FirstName = "John", LastName = "Smith", Age = 35, Country = "USA", Hobbies = new List<string> { "Reading", "Cooking", "Hiking" } },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 32, Country = "Canada", Hobbies = new List<string> { "Reading", "Gaming" } },
                new Person { FirstName = "Michael", LastName = "Brown", Age = 24, Country = "UK", Hobbies = new List<string> { "Swimming", "Hiking" } },
                new Person { FirstName = "Daniel", LastName = "Wilson", Age = 30, Country = "USA", Hobbies = new List<string> { "Gardening", "Singing" } },
                new Person { FirstName = "Emma", LastName = "Johnson", Age = 29, Country = "Canada", Hobbies = new List<string> { "Yoga", "Cooking" } },
                new Person { FirstName = "Olivia", LastName = "Smith", Age = 23, Country = "USA", Hobbies = new List<string> { "Reading", "Gardening" } },
                new Person { FirstName = "James", LastName = "Davis", Age = 26, Country = "Canada", Hobbies = new List<string> { "Traveling" } },
                new Person { FirstName = "Noah", LastName = "Brown", Age = 29, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "Ella", LastName = "Wilson", Age = 28, Country = "USA", Hobbies = new List<string> { "Photography", "Cooking" } },
                new Person { FirstName = "Liam", LastName = "Davis", Age = 31, Country = "Canada", Hobbies = new List<string> { "Reading", "Yoga" } }
            };

            Person searchedPerson = personList
                .Where(person => person.FirstName == "Michael")
                .Where(person => person.LastName == "Brown").FirstOrDefault(); 


            ///find all with gage between 20 and 27 , sort them descending 
            ///find oldest one //oredrByDesending().FirstOrDEfoult()

            //find 5 oldest ones from the list // take()//ThenByDescending

            //Contains(T) returns true ili false.


            //Select first and last name of all people

           /*
            List<string> fullNames = personList
                .Select(person => person.FirstName + " " + person.LastName )//zato sto izdvajamo string 
                .ToList();
             
            */

            //1.

            List<Person> personsFromUSA = personList.Where(p => p.Country == "USA").ToList();
           // Console.WriteLine(personsFromUSA);

            //2.

           Person oldestPerson = personList.OrderByDescending(p => p.Age).FirstOrDefault();
            Console.WriteLine(oldestPerson.FirstName);
            //3.


           
            double averigeAge = personList.Average(p => p.Age);
            Console.WriteLine(averigeAge);
            //4.

            List<Person> firstNameWithJ = personList.Where(p => p.FirstName.StartsWith("J")).ToList();
            Console.WriteLine("FirstNameWithJ");
            foreach (Person item in firstNameWithJ)
            {
                Console.WriteLine(item.FirstName);
            }

            //5.
            List<Person> threeYungestPersons = personList
                .OrderBy(p => p.Age)
                .Take(3)
                .ToList();

            //6.

            bool readingHobbyExists = personList
                .Any(p => p.Hobbies.Contains("Reading"));


            //7.

            List<string> countries = personList
                .DistinctBy(p => p.Country)
                .Select(p => p.Country)
                .ToList();

            //8. 

            List<Person> personsAgeAscending = personList
                .OrderBy(p => p.Age)
                .ToList();

            //9.

            List<Person> personsAge30 = personList
                .Where(p => p.Age == 30)
                .ToList();

            //10.

            List<string> namesFromUK = personList
                .Where(p => p.Country == "UK")
                .Select (p => p.FirstName)
                .ToList();

            //11.

            bool hasAHobby = personList
                .All(p => p.Hobbies.Count() > 0);


            //12.

            List<Person> singingNdencing = personList
                .Where(p => p.Hobbies.Contains("Singing"))
                .Where(p => p.Hobbies.Contains("Dancing"))
                .ToList();


            //13.
          
            Person logestFirstName = personList
                 .OrderByDescending(p => p.FirstName.Length)
                 .FirstOrDefault();

            Person logestLaststName = personList
                 .OrderByDescending(p => p.LastName.Length)
                 .FirstOrDefault();

            //14.

            List<string> fullNames = personList
                .Select(p => p.FirstName + " " + p.LastName)
                .ToList();






        }
    }
}

using UseLINQExercise.Models;

namespace UseLINQExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
            {
            new Person ( "Alice",  25,  "Female" ),
            new Person ( "Bob",  40,  "Male" ),
            new Person ("Charlie",  35,  "Male" ),
            new Person ( "Diana",  50,  "Female" ),
            new Person (  "Eve",  28,  "Female" ),
            };
            List<Person> olderThen30 = people
                .Where(person => person.Age > 30)
                .OrderByDescending(person => person.Age)
                .ToList();
            
            foreach (Person person in olderThen30)
            {
                Console.WriteLine(person.Name);
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} , {person.Age}");
            }
        }
    }
}

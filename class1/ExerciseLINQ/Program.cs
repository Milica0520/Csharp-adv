using ExerciseLINQ.Models;

namespace ExerciseLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person> {
                new Person("Anna",25, "Female"),
                new Person("Bob",35, "Male"),
                new Person("John",38, "Male"),
                new Person("Emma",29, "Female"),
                new Person("Peter",40, "Male"),
                };

            List<Person> olderThen30 = people.Where(person => person.Age > 30 )
                .OrderByDescending(person => person.Age)
                .ToList();

            Console.WriteLine("People older then 30 are: ");
            foreach (Person person in olderThen30)
            {
                Console.WriteLine($"{person.Name}");
            }
            Console.WriteLine("People from the list are: ");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}");
            }


        }
    }
}

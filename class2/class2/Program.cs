using Abstractions.Models;

namespace Abstractions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Abstract classes and interfaces
            //abstract class can not have instance
            
            Developer developer = new Developer();
            developer.Age = 30;
            developer.CurrentRole = Enums.Role.Medior;
            developer.FullName = "Developer One";
            developer.ProgramingLanguages = new List<string> { "C#", "JavaScript" };


            Tester tester = new Tester();
            tester.Age = 30;
            tester.FullName = "Tester One";
            tester.NumberOfBugsFound = 20;
            tester.IsQACertified = true;
            
            Console.WriteLine(developer.GetInfo()); 
            Console.WriteLine(tester.GetInfo());

            Console.WriteLine(" OVO JE ISPIS U FOR PETLJI >>>>>>> ");

            List<Human> humansList = new List<Human>();
            humansList.Add(developer);
            humansList.Add(tester);

            foreach (Human human in humansList)
                Console.WriteLine(human.GetInfo());


        }
    }
}

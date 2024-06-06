using class13.Entitis;
using Newtonsoft.Json;
using System.IO;

namespace class13
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pathToMyJson = "C:\\Users\\micad\\OneDrive\\Desktop\\C#-advanced\\Csharp-adv\\class13\\OurData\\myFirstJson.json";
            string pathToMovies = "C:\\Users\\micad\\OneDrive\\Desktop\\C#-advanced\\Csharp-adv\\class13\\OurData\\movies.json";
            StreamReader streamReader = new StreamReader(pathToMyJson);
            StreamReader streamReaderMovies = new StreamReader(pathToMovies);

            string jsaonContent = String.Empty;
            string jsaonContentMovie = String.Empty;


            using (streamReader)
            {
                jsaonContent = streamReader.ReadToEnd();

            }

            using (streamReaderMovies)
            {
                jsaonContentMovie = streamReaderMovies.ReadToEnd();

            }

            Student student1 = JsonConvert.DeserializeObject<Student>(jsaonContent);

            Console.WriteLine("....THIS IS C# OBJECT");
            Console.WriteLine($"{student1.FirstName}");

            Student student2 = new Student();

            student2.FirstName = "Zoran";
            student2.LastName = "Malinovic";
            student2.Age = 30;
            student2.IsPartTime = false;



            string studentAsJson = JsonConvert.SerializeObject(student2);

            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(jsaonContentMovie);

            foreach (Movie item in movies)
            {
                Console.WriteLine($"{item.Title}");
            }

            ////

            //List<Movie> movieGdade8 = movies
            //    .Where(m => int.Parse(m.imdbRating) > 8)
            //   .ToList();

            //////exercise1

            Console.WriteLine("Enter dog's name: ");
            string dogNameInp = Console.ReadLine();

            Console.WriteLine("Enter dog's age: ");
            int dogAgeInp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dog's color: ");
            string dogColorInp = Console.ReadLine();


            Dog dog = new Dog();
            dog.Name = dogNameInp;
            dog.Age = dogAgeInp;
            dog.Color = dogColorInp;

            string dogAsJson = JsonConvert.SerializeObject(dog);

            string pathToDogs = "C:\\Users\\micad\\OneDrive\\Desktop\\C#-advanced\\Csharp-adv\\class13\\OurData\\dogs.json";
            StreamWriter streamWriter = new StreamWriter(pathToDogs, true);


            using (streamWriter)
            {
              
                streamWriter.WriteLine($"{dogAsJson},");


            }


            StreamReader streamReader1 = new StreamReader(pathToDogs);
            string jsonContentDog = String.Empty;

            using (streamReader1)
            {
                jsonContentDog = streamReader1.ReadToEnd();
                Console.WriteLine(jsonContentDog);

            }














        }
    }
}

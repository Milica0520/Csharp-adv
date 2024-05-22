using class6.Extensions;
using class6.Models;
using class6.Utils;

namespace class6
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("some");
            listOfStrings.Add("testing");
            listOfStrings.Add("words");
            listOfStrings.Add("to learn");
            listOfStrings.Add("about generics");

            List<int> listOfInts = new List<int>() { 1, 2, 3, 4, 6, 6, 21, 21, 22, };
            List<double> listOfFloats = new List<double>() { 1.5, 2.5, 3.2, 4, 6, 6, 21, 21, 22, };
            List<char> listOfChars = new List<char> { 'a', 'l', 'm', 'i', 'r' };


            ListHelper<string> stringHelper = new ListHelper<string>();



            ListHelper<int> listOfIntsH = new ListHelper<int>() ;
            ListHelper<double> listOfFloatsH = new ListHelper<double>() ;
            ListHelper<char> listOfCharsH = new ListHelper<char> ();

            stringHelper.GoThroughList(listOfStrings);

            listOfFloatsH.GoThroughList(listOfFloats);

            if(listOfCharsH.GetType() == typeof(ListHelper<char>))
                Console.WriteLine($"Type of variable is shar.");

          //////
          
            Product product1 = new Product();
            product1.Id = 1;
            product1.Title = "Coca-cola";
            product1.Description = "Soft non alcoholic drink, 1l";



            Product product = new Product();
            product1.Id = 2;
            product1.Title = "Coca-cola Zero";
            product1.Description = "Soft non alcoholic, no sugar drink, 1l";

            Order order1 = new Order();
            order1.Id = 10;
            order1.Receiver = "Miroslav Popovic";
            order1.Adress = "Banja Luka bb";
            /////

            string randomSentence = "Danas je lijep dan, ucimo C# svi zajedno";

            Console.WriteLine(StringExtensions.Shorten( randomSentence, 3));


        }
    }
}

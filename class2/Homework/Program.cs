using Homework.Models;
using System.Reflection.Metadata;
using Document = Homework.Models.Document;

namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> text1 = new List<string>
            {
                "Write a program to create an interface Searchable with a method " +
                "Search(string word) that searches for a given keyword in a text document." +
                " Create two classes Document and WebPage that implement the Searchable interface and " +
                "provide their own implementations of the Search() method.",

            };

            WebPage page = new WebPage(text1);

            Console.WriteLine("Search word:  ");
            string wordInp = Console.ReadLine().ToLower();

                page.Search(wordInp);
            
          
            





        }


    }
}

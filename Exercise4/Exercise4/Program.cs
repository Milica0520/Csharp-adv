using Exercise4.Extensions;

namespace Exercise4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence:");
            string sentenceInp = Console.ReadLine();

            string reversed = sentenceInp.ReverseWords();

            Console.WriteLine($"{reversed}");


        }
    }
}

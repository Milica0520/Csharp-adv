namespace homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole<string> words = new PrintInConsole<string>();

            words.Collection.Add("This");
            words.Collection.Add("is");
            words.Collection.Add("simple");
            words.Collection.Add("sentence.");


            words.PrintCollection();

            words.Print("This");

            
        }
    }
}

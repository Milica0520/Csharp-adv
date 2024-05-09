namespace NumberStats
{
    public class Program
    {
        static void Main(string[] args)
        {
            //continue u  petlji forsa kod na sledecu iteraciju 
            //uradi do while za ponavljanje
            Console.WriteLine("Enter a number:");
            float inputNum = (float)Convert.ToDouble(Console.ReadLine());
            statsNumber(inputNum);
        }
        static void statsNumber(float num)
        {
            Console.WriteLine($"The stuts for {num} is:");
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            if (num % 1 == 0)
            {
                Console.WriteLine("Integer");
            }
            else if (num % 1 > 0)
            {
                Console.WriteLine("Double");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}

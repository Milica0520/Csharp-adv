namespace NumberStats
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isX = false;
            do
            { 
            try
            {
                Console.WriteLine("Enter a number: ");
                float userInp = float.Parse(Console.ReadLine());

                GetStatsNum(userInp);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to try again or X to exit.");
            string userKeyInp = Console.ReadLine();

            if (userKeyInp.ToLower() == "x")
                {
                    isX = true;
                    continue;
                }
               
            }while (isX == false);
        }

        static void GetStatsNum(float num)
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            if (num % 1 == 0) {
                Console.WriteLine("Integer");
            }
            else
            {
                Console.WriteLine("Decimal");
            }
            if(num % 2 == 0)
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

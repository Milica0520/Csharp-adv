namespace RecapExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //task 1
            try
            {
                Console.WriteLine("Enter your name: ");
                string userNameInp = Console.ReadLine();

                Console.WriteLine("Enter your age: ");
                int userInpAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Hallo {userNameInp}, you are {userInpAge} age old.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //task 2 
            Console.WriteLine("Enter a number: ");
            int userNumInp = Int32.Parse(Console.ReadLine());
            if (userNumInp < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if (userNumInp > 0)
            {
                Console.WriteLine("The number is pozitive.");
            }
            else
            {
                Console.WriteLine("The number is equal zero.");
            }
            //task 3
            Console.WriteLine("Enter a number: ");
            int userNumInp3 = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < userNumInp3; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of numbers is {sum}");
        }
    }
}

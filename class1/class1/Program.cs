namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            try
            {
                Console.WriteLine("Please enter your name: ");
            string nameInp = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int ageInp = int.Parse(Console.ReadLine());

           
                Console.WriteLine($"Your name is {nameInp} ang you are {ageInp} years old.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //exercise 2 
            Console.WriteLine("Please enter a number: ");
            int numberInp = int.Parse(Console.ReadLine());

            if(numberInp < 0)
            {
                Console.WriteLine("Negative number.");
            }else if (numberInp > 0) {
                Console.WriteLine("Positive number.");
            }
            else
            {
                Console.WriteLine("Number is equal to zero.");
            }
            //exercise 3
            Console.WriteLine("Please enter a number: ");
            int numberInp3 = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= numberInp3; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
               
            }
            Console.WriteLine($"Sum of all even numbers between 1 and {numberInp3} is {sum}");
        }
    }
}

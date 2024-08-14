namespace TaxiManager9000
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Taxi Manager 9000:");
            Console.WriteLine("Please log in");
            Console.WriteLine("Enter your username:");
            string usernameInp = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string passwordInp = Console.ReadLine();


            if (usernameInp== null || passwordInp == null )
            {
                throw new Exception("Invalid input");
            }
            else
            {

            }




        }
    }
}

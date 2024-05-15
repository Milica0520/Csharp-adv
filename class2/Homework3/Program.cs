using Homework3.Models;

namespace Homework3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle shape1 = new(5.0,2.0);
            Circle shape2 = new(3.5);


            Console.WriteLine($"Triangle perimeter {shape1.CalculatePerimeter()}");
            Console.WriteLine($"Triangle area {shape1.CalculateArea()}");


            Console.WriteLine($"Circle perimeter {shape2.CalculatePerimeter()}");
            Console.WriteLine($"Circle area {shape2.CalculateArea()}");



        }
    }
}

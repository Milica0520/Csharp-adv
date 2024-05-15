using Homework2.Models;

namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle shape1 = new(4.0, 7.0, 3.5);
            Rectangle shape2 = new(3.0, 5.5);
            Circle shape3 = new(3.5);

            shape1.GetArea();
            shape2.GetArea();
            shape3.GetArea();
        }
    }
}

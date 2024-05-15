using Homework4.Models;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menager menager1 = new("Miroslav","Popovic",3000);
            Programmer programer1 = new("Almir","Vuk",2000);


            Console.WriteLine(menager1.CalculateSalary());
            menager1.DisplayInfo();

            Console.WriteLine(programer1.CalculateSalary());
            programer1.DisplayInfo();

        }
    }
}

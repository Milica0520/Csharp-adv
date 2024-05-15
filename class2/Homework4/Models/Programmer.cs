using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class Programmer : Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public Role Role { get; init; } = Role.Programmer;

        public Programmer(string firstName, string lastName, decimal baseSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = baseSalary;
        }
        public override decimal CalculateSalary()
        {
            return BaseSalary + 300;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The employee info : Full Name - {FirstName},{LastName}, Role - {Role}, Salary {CalculateSalary()}");
        }
    }
}

using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework4.Models
{
    public class Menager : Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public Role Role { get; init; } = Role.Menager;

        public Menager(string firstName, string lastName, decimal baseSalary)
        { 
            FirstName = firstName;
            LastName = lastName;    
            BaseSalary = baseSalary;
        }
        public override decimal CalculateSalary()
        {
            return BaseSalary + 500;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The employee info : Full Name - {FirstName},{LastName}, Role - {Role}, Salary {CalculateSalary()}");
        }
    }
}

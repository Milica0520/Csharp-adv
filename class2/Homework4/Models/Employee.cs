using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public abstract class Employee
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary {  get; set; }           
        public abstract decimal CalculateSalary();
        public abstract void DisplayInfo();
    }
}

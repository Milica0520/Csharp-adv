using Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject {  get; set; }

        public Teacher()
        {
           
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {UserName} - {Password} and I am teacher at {Subject} subject");
        }
    }
}

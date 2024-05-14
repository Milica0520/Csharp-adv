using Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string username, string password) 
        {
            Id = id;
            Name = name;
            UserName = username;
            Password = password;

            Grades = new List<string>();

        }

        public List<string> Grades { get ; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {UserName} - {Password}");

            foreach (string grade in Grades)
                Console.WriteLine(grade);
        }

    }
}

using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class BackandDeveloper : Developer,IDeveloper
    {
        public BackandDeveloper(string fullName, int age) : base(fullName, age)
        {


        }

        public void Code()
        {
            Console.WriteLine("I am coding on web beckend side");
        }
        public void Debug()
        {
            Console.WriteLine("I am debugging on web beckend side");
        }
    }
}

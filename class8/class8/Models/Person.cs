using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class8.Models
{
    public class Person
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Age { get; internal set; }
        public string Country { get; internal set; }
        public List<string> Hobbies { get; internal set; }


    }
}

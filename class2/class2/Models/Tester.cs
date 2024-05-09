using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class Tester : Human
    {
    
        public bool IsQACertified {get;set;}
        public int NumberOfBugsFound { get; set; }
        public Tester(string fullName, int age, bool isQACertified) :base(fullName,age)
        {
            IsQACertified = isQACertified;
        }
        public override string GetInfo()
        {
            return $"{FullName} - {Age} - IsQACertified : {IsQACertified} - Number og Gags Found :{NumberOfBugsFound}";
        }
    }
}

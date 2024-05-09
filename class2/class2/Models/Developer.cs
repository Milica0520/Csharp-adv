using Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class Developer : Human
    {
      
        public List<string> ProgramingLanguages { get; set; }
        public Role CurrentRole { get; set; }
        public Developer(string fullName, int age)
          : base(fullName, age)
        {

        }

      

        public override string GetInfo()
        {
        string role = "Junior";

            switch (CurrentRole) 
            {
                case Role.Medior:
                    role = "Medior";
                        break;
                case Role.Senior:
                    role = "Senior";
                    break;
                case Role.Architect:
                    role = "Architect";
                    break;
                case Role.CTO:
                    role = "CTO";
                    break;

            }

            return $"{FullName} - {Age} - Programming Laguages :" +
                $" {string.Join(",",ProgramingLanguages)} , Current Role : {role}";
            
        }
    }
}

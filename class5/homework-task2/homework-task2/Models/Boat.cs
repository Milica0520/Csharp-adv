using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_task2.Models
{
    public class Boat : Vehicle
    {
        public Boat(int numOfweels, string typeOfvehicle) : base(numOfweels, typeOfvehicle)
        {
            NumOfWeels = numOfweels;
            TypeOfVehicle = "boat";
        }

        public override string DisplayInfo()
        {
            if (NumOfWeels == 0 || NumOfWeels < 0)
            {
                return $"I am a {TypeOfVehicle} and I do not have weels. :(";
            }
            else if (NumOfWeels > 1 && NumOfWeels <= 4)
            {
                return $"I am a {TypeOfVehicle} and I have {NumOfWeels} weels. :)";
            }
            else
            {
                return $"I am a {TypeOfVehicle} and I have couple of weels. :) ";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_task2.Models
{
    public abstract class Vehicle
    {
        
        public int? NumOfWeels { get; set; }
        public string TypeOfVehicle { get; set; }
        public Vehicle(int numOfweels,string typeOfvehicle)
        {
            NumOfWeels = numOfweels;   
            TypeOfVehicle = typeOfvehicle;
        }
        public abstract string DisplayInfo();
    }
}

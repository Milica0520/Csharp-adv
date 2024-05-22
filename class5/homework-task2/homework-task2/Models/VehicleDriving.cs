using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_task2.Models
{
    public class VehicleDriving<T> where T : Vehicle
    {
        public List<T> Vehicles;

        public VehicleDriving()
        {
            Vehicles = new List<T>();
        }


        public void Driving()
        {
            foreach (T vehicle in Vehicles)
            {
                if (vehicle.TypeOfVehicle  == "car")
                {
                    Console.WriteLine("Driving");
                }else if (vehicle.TypeOfVehicle == "boat")
                {
                    Console.WriteLine("Sailng");
                }
                else if (vehicle.TypeOfVehicle == "motorbike")
                {
                    Console.WriteLine("Driving on one wheel.");
                }
                else if (vehicle.TypeOfVehicle == "plane")
                {
                    Console.WriteLine("Flying");
                }else
                {
                    Console.WriteLine("Unknown vehicle.");
                }
            }
        }
       
    }
}

using homework_task2.Models;

namespace homework_task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(4, "car");
            Vehicle plane = new AirPlane(12, "plane");
            Vehicle motorBike = new MotorBike(2, "motorbike");
            Vehicle boat = new Boat(0, "boat");

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(motorBike.DisplayInfo());
            Console.WriteLine(boat.DisplayInfo());
            Console.WriteLine(plane.DisplayInfo());

            VehicleDriving<Car> carsToDrive = new VehicleDriving<Car>();
            carsToDrive.Vehicles.Add(new Car(4, "car"));


            VehicleDriving<MotorBike> motorbikesToDrive = new VehicleDriving<MotorBike>();
            motorbikesToDrive.Vehicles.Add(new MotorBike(2, "motorbike"));

            VehicleDriving<AirPlane> planesToDrive = new VehicleDriving<AirPlane>();
            planesToDrive.Vehicles.Add(new AirPlane(12, "plane"));

            VehicleDriving<Boat> boatsToDrive = new VehicleDriving<Boat>();
            boatsToDrive.Vehicles.Add(new Boat(0, "boat"));



            carsToDrive.Driving();
            motorbikesToDrive.Driving();
            planesToDrive.Driving();
            boatsToDrive.Driving();

        }  
    }
}

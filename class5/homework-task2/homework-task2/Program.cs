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
          

        }  
    }
}

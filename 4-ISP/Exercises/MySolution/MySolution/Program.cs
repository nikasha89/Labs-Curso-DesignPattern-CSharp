using ISPLibrary;
using System;

namespace MySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnginedVehicle car = new Car();

            Console.WriteLine("Car:");

            car.Move();

            car.StartEngine();
            car.Move();
            car.StopEngine();

            IVehicle bicycle = new Bicycle();

            Console.WriteLine("Bicycle:");

            bicycle.Move();

            Console.ReadLine();
        }
    }
}

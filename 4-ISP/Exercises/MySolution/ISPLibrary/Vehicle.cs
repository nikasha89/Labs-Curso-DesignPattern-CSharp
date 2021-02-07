using System;

namespace ISPLibrary
{
    public class Vehicle : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public double Position { get; set; }
        public double Velocity { get; set; }

        public Vehicle()
        {
            Position = 0.0;
        }

        public int GetNumberOfWheels()
        {
            return NumberOfWheels;
        }

        public virtual void Move()
        {
            Position += Velocity;
            Console.WriteLine(string.Format("Nos movemos a {0} m/s!", Velocity));
        }
    }
}
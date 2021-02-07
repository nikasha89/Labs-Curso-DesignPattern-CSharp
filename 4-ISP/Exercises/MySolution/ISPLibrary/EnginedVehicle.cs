using System;

namespace ISPLibrary
{
    public class EnginedVehicle : Vehicle, IEnginedVehicle
    {
        public bool MotorRunning { get; set; }

        public EnginedVehicle()
        {
            MotorRunning = false;
        }        

        public int StartEngine()
        {
            MotorRunning = true;
            Console.WriteLine("Motor encendido!");
            return 1;
        }

        public int StopEngine()
        {
            MotorRunning = false;
            Console.WriteLine("Motor apagado!");
            return 1;
        }

        public override void Move()
        {
            if (MotorRunning)
            {
                double initial = Position;
                Position += Velocity;
                Console.WriteLine(string.Format("Nos movemos a {0} m/s!", Velocity));
                Console.WriteLine(string.Format("Nos movimos de la posición {0} a la {1}", initial, Position));
            }                
            else
                Console.WriteLine("Motor Apagado :(");
        }
    }
}

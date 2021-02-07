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
            return 1;
        }

        public int StopEngine()
        {
            MotorRunning = false;
            return 1;
        }

        public override void Move()
        {
            if (MotorRunning)
            {
                Position += Velocity;
                Console.WriteLine(string.Format("Nos movemos a {0} m/s!", Velocity));
            }                
            else
                Console.WriteLine("Motor Apagado :(");
        }
    }
}

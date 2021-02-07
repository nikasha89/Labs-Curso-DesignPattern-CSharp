using System;

namespace LSPLibrary
{
    public class Animal : IAnimal
    {
        public string Noise;
        public virtual void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}

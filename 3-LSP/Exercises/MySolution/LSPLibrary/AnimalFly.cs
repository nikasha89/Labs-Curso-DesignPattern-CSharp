using System;

namespace LSPLibrary
{
    public class AnimalFly : Animal, IAnimalFly
    {
        public virtual void Fly()
        {
            Console.WriteLine("Estoy volando");
        }
    }
}

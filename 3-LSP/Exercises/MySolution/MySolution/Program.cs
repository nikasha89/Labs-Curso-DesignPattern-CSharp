using LSPLibrary;
using System;

namespace MySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFly bird = new Bird();

            Console.WriteLine("Bird:");

            bird.MakeNoise();
            bird.Fly();

            IAnimal dog = new Dog();

            Console.WriteLine("Dog:");

            dog.MakeNoise();

            Console.ReadLine();
        }
    }
}

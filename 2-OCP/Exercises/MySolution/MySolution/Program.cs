using OCPLibrary.BusinessClasses;
using System;
using System.Collections.Generic;

namespace MySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                new Mamifero { Name = "Tigre", Order = AnimalOrder.Carnivoro },
                new Mamifero { Name = "Chimpancé", Order = AnimalOrder.Omnivoro },
                new Ave { Name = "Aguila", Order = AnimalOrder.Carnivoro },
                new Ave { Name = "Condor", Order = AnimalOrder.Carnivoro },
                new Pez { Name = "Pez globo", Order = AnimalOrder.Carnivoro },
                new Mamifero { Name = "Vaca", Order = AnimalOrder.Herbivoro },
                new Mamifero { Name = "Oveja", Order = AnimalOrder.Herbivoro }
            };

            animals.ForEach(animal => Console.WriteLine(animal.ToString()));
            
            Console.WriteLine("Aves:");
            var birds = new AnimalFilter().FilterByClass(animals, AnimalClass.Aves);
            birds.ForEach(bird => Console.WriteLine(bird.ToString()));
                                 
            Console.ReadLine();
        }
    }
}

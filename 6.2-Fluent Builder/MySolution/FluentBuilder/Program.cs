using BuilderLibrary;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder()
                .WithModel("Mercedes")
                .WithName("Benz");

            Console.WriteLine(builder.Car.Name + " " + builder.Car.Model);
            Console.ReadLine();
        }
    }
}

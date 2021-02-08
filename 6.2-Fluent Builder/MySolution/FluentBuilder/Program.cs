using BuilderLibrary;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder()
                .CreateNew()
                .AddModel("Mercedes")
                .AddName("Benz")
                .Build();

            Console.WriteLine(builder.Name + " " + builder.Model);
            Console.ReadLine();
        }
    }
}

using MySolution.BusinessClasses;
using System;
using System.Collections.Generic;

namespace MySolutionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMessage> messages = new List<IMessage>
            {
                new SMS()
                {
                    Content = "SMS content",
                    Receiver = "699696969"
                },
                new Email()
                {
                    Content = "Email content",
                    Receiver = "paqueando@gmail69.com"
                }
            };

            Console.WriteLine("Creamos Empleado:");

            IEmployee employee = new Employee(messages);

            employee.SendMessages();

            Console.ReadLine();
        }
    }
}

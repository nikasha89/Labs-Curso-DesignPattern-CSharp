using System;

namespace MySolution.BusinessClasses
{
    public class Message : IMessage
    {
        public string Receiver { get; set; }
        public string Content { get; set; }
        public void Send()
        {
            //Send Message
            Console.WriteLine(string.Format("Mensaje {0} enviado a {1}", Content, Receiver));
        }
    }
}
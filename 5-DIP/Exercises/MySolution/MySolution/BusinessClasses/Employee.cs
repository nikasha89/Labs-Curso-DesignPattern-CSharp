using System.Collections.Generic;

namespace MySolution.BusinessClasses
{
    public class Employee : IEmployee
    {
        private List<IMessage> _messages;

        public Employee(List<IMessage> messages)
        {
            _messages = messages;
        }

        public void SendMessages()
        {
            _messages.ForEach(message => message.Send());
        }
    }
}

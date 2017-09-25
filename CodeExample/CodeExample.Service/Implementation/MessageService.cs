using CodeExample.Entities;
using CodeExample.Service.Interface;

namespace CodeExample.Service.Implementation
{
    public class MessageService : IMessageService, System.IDisposable
    {
        public MessageService()
        {
        }

        public void Dispose()
        {
        }

        public void ProcessMessage(Message message)
        {
            if (string.IsNullOrWhiteSpace(message.Input))
            {
                message.Response = "No Really Please Enter your name";
                message.ValidInput = false;
            }
            else
            {
                message.Response = $"Hello {message.Input}";
                message.ValidInput = true;
            }
        }
    }
}

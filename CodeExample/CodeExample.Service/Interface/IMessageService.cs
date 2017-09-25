using CodeExample.Entities;

namespace CodeExample.Service.Interface
{
    public interface IMessageService
    {
        void ProcessMessage(Message message);
    }
}

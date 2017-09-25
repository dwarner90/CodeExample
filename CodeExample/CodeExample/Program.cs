using CodeExample.Service.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using CodeExample.Service.Interface;

namespace CodeExample
{
    class Program
    {
        private static Entities.Message _message;
        static void Main(string[] args)
        {
            var services = new ServiceCollection().AddSingleton<IMessageService, MessageService>().BuildServiceProvider();
            var messageService = services.GetService<IMessageService>();

            Console.WriteLine("Please Enter Your name:");
            CollectInput(messageService);
  
            while (!_message.ValidInput)
            {
                CollectInput(messageService);
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }

        private static void CollectInput(IMessageService messageService)
        {
         
            var input = Console.ReadLine();

            _message = new Entities.Message()
            {
                Input = input
            };

            messageService.ProcessMessage(_message);
            Console.WriteLine(_message.Response);
        }
    }
}

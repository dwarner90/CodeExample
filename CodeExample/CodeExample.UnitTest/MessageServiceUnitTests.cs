
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeExample.Service.Implementation;
using CodeExample.Entities;

namespace CodeExample.UnitTest
{
    [TestClass]
    public class MessageServiceUnitTests
    {
        private MessageService _messageService;

        [TestInitialize]
        public void SetUp()
        {
            _messageService = new MessageService();
        }

        [TestMethod]
        public void TestValidInput()
        {
            var newMessage = new Message()
            {
                Input = "Dustin Warner"
            };

            _messageService.ProcessMessage(newMessage);

            Assert.IsTrue(newMessage.ValidInput);
            Assert.AreEqual(newMessage.Response, $"Hello {newMessage.Input}");
        }
        [TestMethod]
        public void TestInvalidInput()
        {
            var newMessage = new Message()
            {
                Input = null
            };

            _messageService.ProcessMessage(newMessage);

            Assert.IsFalse(newMessage.ValidInput);
            Assert.AreEqual(newMessage.Response, "No Really Please Enter your name");
        }
    }
}

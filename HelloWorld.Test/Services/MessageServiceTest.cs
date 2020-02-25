using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Service;

namespace HelloWorld.Test.Services
{
    [TestClass]
    public class MessageServiceTest
    {
        private IMessageService _messageService;


        [TestInitialize]
        public void TestInitialize()
        {
            _messageService = new MessageService();
        }

        [TestMethod]
        public void ShouldReturnHelloWorld()
        {
            //Arrange
            string message = "Hello World";
            //Act
            string result = _messageService.GetMessage();
            //Assert
            Assert.AreEqual(result, message);
        }

    }
}

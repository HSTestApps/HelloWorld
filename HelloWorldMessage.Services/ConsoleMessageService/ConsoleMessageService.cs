using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldMessage.Services
{
    public class ConsoleMessageService : IConsoleMessageService
    {
        public bool SendMessage(string message)
        {
            Console.WriteLine($"{message}");
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldMessage.Services
{
    public interface IMessageService
    {
        bool SendMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Service
{
    public class MessageService:IMessageService
    {        
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}

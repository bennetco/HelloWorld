using System;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleOutputService : IHelloWorldOutputService
    {
        public void OutputHelloWorld(HelloWorldDTO content)
        {
            Console.Write(content.Message);
        }
    }
}

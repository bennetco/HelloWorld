using System;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleOutputService : HelloWorldOutputServiceBase
    {
        public override void OutputHelloWorld(HelloWorldDTO content)
        {
            Console.Write(content.Message);
        }
    }
}

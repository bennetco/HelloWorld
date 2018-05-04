using System;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class DefaultHelloWorldOutputService : IHelloWorldOutputService
    {
        public void OutputHelloWorld(HelloWorldDTO content)
        {
            Console.Write(content.Message);
        }
    }
}

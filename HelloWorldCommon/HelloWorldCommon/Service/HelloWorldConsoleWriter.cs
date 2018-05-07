using System;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldContentProvider _provider;

        public HelloWorldConsoleWriter(IHelloWorldContentProvider provider)
        {
            _provider = provider;
        }

        public override void WriteHelloWorld()
        {
            Console.Write(_provider.GetHelloWorldContent().Message);
        }
    }
}

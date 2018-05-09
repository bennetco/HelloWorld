using System;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldReader _provider;

        public HelloWorldConsoleWriter(IHelloWorldReader provider)
        {
            _provider = provider;
        }

        public override void WriteHelloWorld()
        {
            Console.Write(_provider.GetHelloWorldContent().Message);
        }
    }
}

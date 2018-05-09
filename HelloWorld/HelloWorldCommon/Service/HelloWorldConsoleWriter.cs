using System;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldReader _reader;

        public HelloWorldConsoleWriter(IHelloWorldReader reader)
        {
            _reader = reader;
        }

        public override void WriteHelloWorld()
        {
            Console.Write(_reader.GetHelloWorldContent().Message);
        }
    }
}
using System;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class HelloWorldConsoleReader : HelloWorldReaderBase
    {
        public override HelloWorldDTO GetHelloWorldContent()
        {
            var msg = Console.ReadLine();

            return new HelloWorldDTO
            {
                Message = msg
            };
        }
    }
}

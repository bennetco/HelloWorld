using HelloWorldCommon.Service;
using System;

namespace HelloWorldExample
{
    public class HelloWorldOutputApplication
    {
        private readonly IHelloWorldContentProvider _contentService;
        private readonly IHelloWorldWriter _outputService;

        public HelloWorldOutputApplication(IHelloWorldContentProvider contentService,
            IHelloWorldWriter outputService)
        {
            _contentService = contentService;
            _outputService = outputService;
        }

        public void Run()
        {
            var content = _contentService.GetHelloWorldContent();
            _outputService.WriteHelloWorld();
            Console.Read();
        }
    }
}

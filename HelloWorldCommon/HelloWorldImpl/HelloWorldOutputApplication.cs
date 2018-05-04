using HelloWorldCommon.Service;
using System;

namespace HelloWorldExample
{
    public class HelloWorldOutputApplication
    {
        private readonly IHelloWorldContentService _contentService;
        private readonly IHelloWorldOutputService _outputService;

        public HelloWorldOutputApplication(IHelloWorldContentService contentService,
            IHelloWorldOutputService outputService)
        {
            _contentService = contentService;
            _outputService = outputService;
        }

        public void Run()
        {
            var content = _contentService.GetHelloWorldContent();
            _outputService.OutputHelloWorld(content);
            Console.Read();
        }
    }
}

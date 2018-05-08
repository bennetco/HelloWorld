using HelloWorldCommon.Service;

namespace HelloWorldExample
{
    public class WriteHelloWorldApplication
    {
        private readonly IHelloWorldWriter _writer;

        public WriteHelloWorldApplication(IHelloWorldWriter writer)
        {
            _writer = writer;
        }

        public void Run()
        {
            _writer.WriteHelloWorld();
        }
    }
}

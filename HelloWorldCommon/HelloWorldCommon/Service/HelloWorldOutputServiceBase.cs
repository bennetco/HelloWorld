using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public abstract class HelloWorldOutputServiceBase : IHelloWorldOutputService
    {
        public abstract void OutputHelloWorld(HelloWorldDTO content);
    }
}

using HelloWorldCommon.Repository;

namespace HelloWorldExample.Repository
{
    public class HelloWorldBasicRepo : IHelloWorldRepo
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}

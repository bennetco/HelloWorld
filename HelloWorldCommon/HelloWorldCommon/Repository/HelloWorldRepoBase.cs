namespace HelloWorldCommon.Repository
{
    public abstract class HelloWorldRepoBase : IHelloWorldRepo
    {
        public virtual string GetHelloWorldMessage()
        {
            return "Hello World";
        }

        public abstract void StoreHelloWorldMessage(string message);
    }    
}

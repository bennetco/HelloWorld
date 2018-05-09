namespace HelloWorldCommon.Repository
{
    public abstract class HelloWorldRepoBase : IHelloWorldRepo
    {
        public abstract string GetHelloWorldMessage();

        public abstract void StoreHelloWorldMessage(string message);
    }    
}
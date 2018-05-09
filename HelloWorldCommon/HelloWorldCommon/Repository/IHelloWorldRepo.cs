namespace HelloWorldCommon.Repository
{
    public interface IHelloWorldRepo
    {
        string GetHelloWorldMessage();
        void StoreHelloWorldMessage(string message);
    }
}
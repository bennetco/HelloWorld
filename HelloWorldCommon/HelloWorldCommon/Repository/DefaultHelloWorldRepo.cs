namespace HelloWorldCommon.Repository
{
    public class DefaultHelloWorldRepo : HelloWorldRepoBase
    {
        public override string GetHelloWorldMessage()
        {
            return "Hello World";
        }

        public override void StoreHelloWorldMessage(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}

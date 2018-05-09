using System;

namespace HelloWorldCommon.Repository
{
    public class DefaultHelloWorldRepo : HelloWorldRepoBase
    {
        public override string GetHelloWorldMessage()
        {
            return Constants.HelloWorldValue;
        }

        public override void StoreHelloWorldMessage(string message)
        {
            throw new NotImplementedException("Default repo does not support storing");
        }
    }
}
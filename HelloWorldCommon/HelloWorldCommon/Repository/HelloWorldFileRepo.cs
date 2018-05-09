using System;

namespace HelloWorldCommon.Repository
{
    public class HelloWorldFileRepo : HelloWorldRepoBase
    {
        private readonly string _filePath;

        public HelloWorldFileRepo(string filePath)
        {
            _filePath = filePath;
        }

        public override string GetHelloWorldMessage()
        {
            throw new NotImplementedException("Not implemented for this exercise");
        }

        public override void StoreHelloWorldMessage(string message)
        {
            throw new NotImplementedException("Not implemented for this exercise");
        }
    }
}

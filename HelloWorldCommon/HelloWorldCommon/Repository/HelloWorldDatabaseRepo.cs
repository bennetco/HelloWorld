using System;

namespace HelloWorldCommon.Repository
{
    public class HelloWorldDatabaseRepo : HelloWorldRepoBase
    {
        private readonly string _connectionString;

        public HelloWorldDatabaseRepo(string connectionString)
        {
            _connectionString = connectionString;
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
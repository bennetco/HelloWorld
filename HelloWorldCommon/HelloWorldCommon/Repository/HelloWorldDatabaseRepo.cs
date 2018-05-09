using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public override void StoreHelloWorldMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}

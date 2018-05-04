﻿using HelloWorldCommon.Repository;

namespace HelloWorldExample.Repository
{
    public class DefaultHelloWorldRepo : IHelloWorldRepo
    {
        public string GetHelloWorldMessage()
        {
            return "Hello World";
        }

        public void StoreHelloWorldMessage(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}

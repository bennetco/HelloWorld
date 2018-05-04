using System;
using System.Collections.Generic;
using System.Text;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public abstract class HelloWorldContentServiceBase : IHelloWorldContentService
    {
        public abstract HelloWorldDTO GetHelloWorldContent();
        public abstract void StoreHelloWorldContent(HelloWorldDTO content);
    }
}

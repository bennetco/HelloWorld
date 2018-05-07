using System;
using System.Collections.Generic;
using System.Text;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public abstract class HelloWorldContentProviderBase : IHelloWorldContentProvider
    {
        public abstract HelloWorldDTO GetHelloWorldContent();
    }
}

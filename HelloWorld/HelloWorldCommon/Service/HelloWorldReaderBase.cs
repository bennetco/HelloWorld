using System;
using System.Collections.Generic;
using System.Text;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public abstract class HelloWorldReaderBase : IHelloWorldReader
    {
        public abstract HelloWorldDTO GetHelloWorldContent();
    }
}
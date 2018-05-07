﻿using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public abstract class HelloWorldWriterBase : IHelloWorldWriter
    {
        public abstract void OutputHelloWorld(HelloWorldDTO content);
    }
}

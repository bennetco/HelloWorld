﻿using HelloWorldCommon.Service;
using System;

namespace HelloWorldExample
{
    public class HelloWorldOutputApplication
    {
        private readonly IHelloWorldWriter _writer;

        public HelloWorldOutputApplication(IHelloWorldWriter writer)
        {
            _writer = writer;
        }

        public void Run()
        {
            _writer.WriteHelloWorld();
        }
    }
}

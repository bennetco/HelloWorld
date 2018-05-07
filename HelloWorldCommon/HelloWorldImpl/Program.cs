using System;
using Microsoft.Extensions.DependencyInjection;
using HelloWorldCommon.Repository;
using HelloWorldExample.Repository;
using HelloWorldCommon.Service;
using HelloWorldExample.Service;

namespace HelloWorldExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IHelloWorldRepo, DefaultHelloWorldRepo>()
                .AddSingleton<IHelloWorldContentProvider, DefaultHelloWorldContentService>()
                .AddSingleton<IHelloWorldWriter, HelloWorldConsoleWriter>()
                .AddSingleton<HelloWorldOutputApplication>()
                .BuildServiceProvider();

            serviceProvider.GetRequiredService<HelloWorldOutputApplication>().Run();
        }
    }
}

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
                .AddSingleton<IHelloWorldRepo, HelloWorldBasicRepo>()
                .AddSingleton<IHelloWorldService, HelloWorldService>()
                .BuildServiceProvider();

            var data = serviceProvider.GetService<IHelloWorldService>().GetHelloWorld();

            Console.Write(data.Message);
            Console.Read();
        }
    }
}

using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace HelloWorldExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("./appSettings.json")
                .Build();

            var builder = new ContainerBuilder();
            
            builder.RegisterModule(new ConfigurationModule(config));            
            builder.RegisterType<WriteHelloWorldApplication>();

            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<WriteHelloWorldApplication>().Run();
            }  
        }
    }
}
using System;
using Autofac;
using HelloWorldCommon.Service;
using HelloWorldCommon.Repository;

namespace HelloWorldCommon.Modules
{
    public class HelloWorldReaderModule : Module
    {
        public string WhereToRead { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            switch (WhereToRead.ToLowerInvariant())
            {
                case "repo":
                case "repository":
                    RegisterRepoReader(builder);
                    break;

                case "console":
                default:
                    RegisterConsoleReader(builder);
                    break;
            }
        }

        private void RegisterConsoleReader(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldConsoleReader())
                .As<IHelloWorldReader>();
        }

        private void RegisterRepoReader(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldRepoReader(cxt.Resolve<IHelloWorldRepo>()))
                .As<IHelloWorldReader>();
        }
    }
}

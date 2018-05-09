using Autofac;
using HelloWorldCommon.Service;
using HelloWorldCommon.Repository;

namespace HelloWorldCommon.Modules
{
    public class HelloWorldWriterModule : Module
    {
        public string WhereToWrite { get; set; }   

        protected override void Load(ContainerBuilder builder)
        {            
            switch (WhereToWrite.ToLowerInvariant())
            {
                case "repo":
                case "repository":
                    RegisterRepoWriter(builder);
                    break;

                case "console":
                default:
                    RegisterConsoleWriter(builder);
                    break;
            }
        }

        private void RegisterRepoWriter(ContainerBuilder builder)
        {
            builder
                .Register(cxt => new HelloWorldRepoWriter(cxt.Resolve<IHelloWorldReader>(),
                    cxt.Resolve<IHelloWorldRepo>()))
                .As<IHelloWorldWriter>();
        }

        private void RegisterConsoleWriter(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldConsoleWriter(cxt.Resolve<IHelloWorldReader>()))
                .As<IHelloWorldWriter>();
        }
    }
}

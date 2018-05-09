using Autofac;
using HelloWorldCommon.Repository;
using System;

namespace HelloWorldCommon.Modules
{
    public class HelloWorldRepoModule : Module
    {
        public string RepoType { get; set; }

        public string ConnectionString { get; set; }

        public string FilePath { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            switch (RepoType.ToLowerInvariant())
            {
                case "database":
                    RegisterDatabaseRepo(builder);
                    break;

                case "file":
                    RegisterFileRepo(builder);
                    break;

                case "default":
                default:
                    RegisterDefaultRepo(builder);
                    break;
            }
        }

        private void RegisterDatabaseRepo(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldDatabaseRepo(ConnectionString))
                .As<IHelloWorldRepo>();
        }

        private void RegisterFileRepo(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldFileRepo(FilePath))
                .As<IHelloWorldRepo>();
        }

        private void RegisterDefaultRepo(ContainerBuilder builder)
        {
            builder.Register(cxt => new DefaultHelloWorldRepo())
                .As<IHelloWorldRepo>();
        }
    }
}

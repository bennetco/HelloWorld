using Autofac;
using HelloWorldCommon.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldExample.Modules
{
    public class HelloWorldRepoModule : Module
    {
        public string RepoType { get; set; }

        public string ConnectionString { get; set; }

        public string FileName { get; set; }

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

                default:
                    RegisterDefaultRepo(builder);
                    break;
            }
        }

        private void RegisterDatabaseRepo(ContainerBuilder builder)
        {
            throw new NotImplementedException();
        }

        private void RegisterFileRepo(ContainerBuilder builder)
        {
            throw new NotImplementedException();
        }

        private void RegisterDefaultRepo(ContainerBuilder builder)
        {
            builder.Register(cxt => new HelloWorldRepo())
                .As<IHelloWorldRepo>();
        }
    }
}

using Autofac;

namespace HelloWorldExample.Modules
{
    public class HelloWorldWriterModule : Module
    {
        public string WhereToWrite { get; set; }
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            
        }
    }
}

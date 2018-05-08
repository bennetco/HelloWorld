using Autofac;

namespace HelloWorldCommon.Modules
{
    public class HelloWorldWriterModule : Module
    {
        public string Something { get; set; }
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            
        }

    }
}

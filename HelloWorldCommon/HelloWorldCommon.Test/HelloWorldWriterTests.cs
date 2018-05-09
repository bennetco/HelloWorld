using Autofac;
using HelloWorldCommon.Repository;
using HelloWorldCommon.Service;
using HelloWorldCommon.DTO;
using Moq;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace HelloWorldCommon.Test
{
    public class HelloWorldWriterFixture : IDisposable
    {
        public IContainer Container { get; set; }

        public HelloWorldWriterFixture()
        {            
            var builder = new ContainerBuilder();

            builder.Register(cxt => Mock.Of<IHelloWorldRepo>())
                .As<IHelloWorldRepo>();

            builder.Register(cxt => Mock.Of<IHelloWorldReader>(x => x.GetHelloWorldContent() == new HelloWorldDTO {
                    Message = Constants.HelloWorldValue
                }))
                .As<IHelloWorldReader>();
            
            //explicitly registering b/c ConsoleWriter can't be tested in same manner as e.g. RepoWriter
            builder.Register(cxt => new HelloWorldConsoleWriter(cxt.Resolve<IHelloWorldReader>()));
            builder.Register(cxt => new HelloWorldRepoWriter(cxt.Resolve<IHelloWorldReader>(), cxt.Resolve<IHelloWorldRepo>()));

            builder.Register(cxt => new StringWriter(new StringBuilder()));
            
            Container = builder.Build();            
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }

    public class HelloWorldWriterTests : IClassFixture<HelloWorldWriterFixture>
    {
        HelloWorldWriterFixture _fixture;

        public HelloWorldWriterTests(HelloWorldWriterFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void WriteHelloWorld_OutputsHelloWorld()
        {
            using (var scope = _fixture.Container.BeginLifetimeScope())
            {
                var output = "";

                if (scope.TryResolve(out HelloWorldConsoleWriter consoleWriter))
                {
                    var newOut = scope.Resolve<StringWriter>();

                    Console.SetOut(newOut);
                    consoleWriter.WriteHelloWorld();

                    output = newOut.GetStringBuilder().ToString();
                }
                else if(scope.TryResolve(out HelloWorldRepoWriter repoWriter))
                {
                    //etc
                }

                Assert.Equal(Constants.HelloWorldValue, output);
            }
        }
    }
}
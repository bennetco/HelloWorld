using Autofac;
using HelloWorldCommon.Modules;
using HelloWorldCommon.Repository;
using HelloWorldCommon.Service;
using Moq;
using System;
using Xunit;

namespace HelloWorldCommon.Test
{
    public class HelloWorldReaderFixture : IDisposable
    {
        public IContainer Container { get; set; }

        public HelloWorldReaderFixture()
        {
            var builder = new ContainerBuilder();

            builder.Register(cxt => Mock.Of<IHelloWorldRepo>(x => x.GetHelloWorldMessage() == Constants.HelloWorldValue))
                .As<IHelloWorldRepo>();

            builder.RegisterModule(new HelloWorldReaderModule { WhereToRead = "repo" });

            Container = builder.Build();
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }

    public class HelloWorldReaderTests : IClassFixture<HelloWorldReaderFixture>
    {
        HelloWorldReaderFixture _fixture;

        public HelloWorldReaderTests(HelloWorldReaderFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void GetHelloWorldContent_ReturnsHelloWorldContentWithHelloWorldMessage()
        {
            using (var scope = _fixture.Container.BeginLifetimeScope()) {
                var content = scope.Resolve<IHelloWorldReader>().GetHelloWorldContent();
                Assert.NotNull(content);
                Assert.Equal(Constants.HelloWorldValue, content.Message);
            }
        }
    }
}
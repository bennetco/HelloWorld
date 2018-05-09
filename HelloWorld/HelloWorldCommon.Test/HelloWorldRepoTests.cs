using HelloWorldCommon.Repository;
using System;
using Autofac;
using Xunit;
using HelloWorldCommon.Modules;

namespace HelloWorldCommon.Test
{
    public class HelloWorldRepoFixture : IDisposable
    {
        public IContainer Container { get; set; }

        public HelloWorldRepoFixture()
        {
            var builder = new ContainerBuilder();            
            builder.RegisterModule(new HelloWorldRepoModule { RepoType = "default" });
            Container = builder.Build();
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }

    public class HelloWorldRepoTests : IClassFixture<HelloWorldRepoFixture>
    {
        HelloWorldRepoFixture _fixture;

        public HelloWorldRepoTests(HelloWorldRepoFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]        
        public void GetHelloWorldMessage_ReturnsHelloWorld()
        {
            using (var scope = _fixture.Container.BeginLifetimeScope())
            {
                var msg = scope.Resolve<IHelloWorldRepo>().GetHelloWorldMessage();
                Assert.Equal(Constants.HelloWorldValue, msg);
            }
        }

        [Fact]
        public void StoreHelloWorldMessage_ThrowsNotImplemented()
        {
            using (var scope = _fixture.Container.BeginLifetimeScope())
            {
                Assert.Throws<NotImplementedException>(() => {
                    scope.Resolve<IHelloWorldRepo>().StoreHelloWorldMessage(Constants.HelloWorldValue);
                    });
            }
        }
    }
}
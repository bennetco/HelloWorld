using HelloWorldCommon.Repository;

namespace HelloWorldCommon.Service
{
    public class HelloWorldRepoWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldReader _provider;
        private readonly IHelloWorldRepo _repo;

        public HelloWorldRepoWriter(IHelloWorldReader provider,
            IHelloWorldRepo repo)
        {
            _provider = provider;
            _repo = repo;
        }
        
        public override void WriteHelloWorld()
        {
            _repo.StoreHelloWorldMessage(_provider.GetHelloWorldContent().Message);
        }
    }
}

using HelloWorldCommon.Repository;

namespace HelloWorldCommon.Service
{
    public class HelloWorldRepoWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldContentProvider _provider;
        private readonly IHelloWorldRepo _repo;

        public HelloWorldRepoWriter(IHelloWorldContentProvider provider,
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

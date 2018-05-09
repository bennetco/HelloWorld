using HelloWorldCommon.Repository;

namespace HelloWorldCommon.Service
{
    public class HelloWorldRepoWriter : HelloWorldWriterBase
    {
        private readonly IHelloWorldReader _reader;
        private readonly IHelloWorldRepo _repo;

        public HelloWorldRepoWriter(IHelloWorldReader reader,
            IHelloWorldRepo repo)
        {
            _reader = reader;
            _repo = repo;
        }
        
        public override void WriteHelloWorld()
        {
            _repo.StoreHelloWorldMessage(_reader.GetHelloWorldContent().Message);
        }
    }
}
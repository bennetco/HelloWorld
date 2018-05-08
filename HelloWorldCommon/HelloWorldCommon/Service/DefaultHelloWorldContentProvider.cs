using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    internal class HelloWorldContentProvider : HelloWorldContentProviderBase
    {
        private readonly IHelloWorldRepo _repo;

        public HelloWorldContentProvider(IHelloWorldRepo repo)
        {
            _repo = repo;
        }

        public override HelloWorldDTO GetHelloWorldContent()
        {
            return new HelloWorldDTO
            {
                Message = _repo.GetHelloWorldMessage()
            };
        }
    }
}

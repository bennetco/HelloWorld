using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class HelloWorldRepoReader : HelloWorldContentProviderBase
    {
        private readonly IHelloWorldRepo _repo;

        public HelloWorldRepoReader(IHelloWorldRepo repo)
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

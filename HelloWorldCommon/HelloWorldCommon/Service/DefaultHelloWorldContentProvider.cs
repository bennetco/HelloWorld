using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public class DefaultHelloWorldContentProvider : HelloWorldContentProviderBase
    {
        private IHelloWorldRepo _repo;

        public DefaultHelloWorldContentProvider(IHelloWorldRepo repo)
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

using HelloWorldCommon.Service;
using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldExample.Service
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

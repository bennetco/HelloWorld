using HelloWorldCommon.Service;
using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldExample.Service
{
    public class DefaultHelloWorldContentService : HelloWorldContentServiceBase
    {
        private IHelloWorldRepo _repo;

        public DefaultHelloWorldContentService(IHelloWorldRepo repo)
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

        public override void StoreHelloWorldContent(HelloWorldDTO content)
        {
            _repo.StoreHelloWorldMessage(content.Message);
        }
    }
}

using HelloWorldCommon.Service;
using HelloWorldCommon.Repository;
using HelloWorldCommon.DTO;

namespace HelloWorldExample.Service
{
    public class DefaultHelloWorldContentService : IHelloWorldContentService
    {
        private IHelloWorldRepo _repo;

        public DefaultHelloWorldContentService(IHelloWorldRepo repo)
        {
            _repo = repo;
        }

        public HelloWorldDTO GetHelloWorldContent()
        {
            return new HelloWorldDTO
            {
                Message = _repo.GetHelloWorldMessage()
            };
        }

        public void StoreHelloWorldContent(HelloWorldDTO content)
        {
            _repo.StoreHelloWorldMessage(content.Message);
        }
    }
}

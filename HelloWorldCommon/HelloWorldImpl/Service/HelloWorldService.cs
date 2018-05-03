using HelloWorldCommon.Service;
using HelloWorldCommon.DTO;
using HelloWorldCommon.Repository;

namespace HelloWorldExample.Service
{
    public class HelloWorldService : IHelloWorldService
    {
        private IHelloWorldRepo _repo;

        public HelloWorldService(IHelloWorldRepo repo)
        {
            _repo = repo;
        }

        public HelloWorldDTO GetHelloWorld()
        {
            return new HelloWorldDTO
            {
                Message = _repo.GetMessage()
            };
        }
    }
}

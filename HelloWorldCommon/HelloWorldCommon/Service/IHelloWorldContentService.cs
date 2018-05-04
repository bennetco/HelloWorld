using HelloWorldCommon.DTO;

namespace HelloWorldCommon.Service
{
    public interface IHelloWorldContentService
    {
        HelloWorldDTO GetHelloWorldContent();
        void StoreHelloWorldContent(HelloWorldDTO content);
    }
}

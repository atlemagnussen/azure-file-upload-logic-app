using System.Threading.Tasks;

namespace TestUploadFileWebApi.authstuff
{
    public interface IGetApiKeyQuery
    {
        Task<ApiKey> Execute(string providedApiKey);
    }
}
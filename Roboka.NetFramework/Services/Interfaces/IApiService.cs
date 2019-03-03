using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roboka.NetFramework.Services.Interfaces
{
    public interface IApiService
    {
        Task<T> PostAsync<T>(string url, object body, Dictionary<string, string> headers = null) where T : class;
        Task<T> UploadBinaryAsync<T>(string url, string filePath, Dictionary<string, string> headers = null) where T : class;
    }
}

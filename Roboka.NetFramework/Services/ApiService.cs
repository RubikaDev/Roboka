using System;
using Newtonsoft.Json;
using Roboka.NetFramework.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Roboka.NetFramework.Services
{
    public class ApiService : IApiService
    {
        public async Task<T> PostAsync<T>(string url, object body, Dictionary<string, string> headers = null) where T : class
        {
            string apiResult;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    httpWebRequest.Headers.Add(header.Key, header.Value);
                }
            }

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(body,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            using (var response = (HttpWebResponse)await httpWebRequest.GetResponseAsync())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                apiResult = await reader.ReadToEndAsync();
            }

            return string.IsNullOrEmpty(apiResult) ? null : JsonConvert.DeserializeObject<T>(apiResult);
        }

        public async Task<T> UploadBinaryAsync<T>(string url, string filePath, Dictionary<string, string> headers = null) where T : class
        {
            var webRequest = WebRequest.Create(url);
            webRequest.Method = "POST";

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    webRequest.Headers.Add(header.Key, header.Value);
                }
            }

            byte[] byteArray;
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byteArray = new byte[file.Length];
                file.Read(byteArray, 0, (int)file.Length);
            }

            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            using (var requestStream = await webRequest.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(byteArray, 0, byteArray.Length);
                using (var response = await webRequest.GetResponseAsync())
                {
                    var webResponse = (HttpWebResponse)response;
                    if (webResponse.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"UploadFile ERROR: StatusCode: {webResponse.StatusCode}, FilePath: {filePath}, Url: {url}");

                    using (var responseStream = response.GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        var responseFromServer = await reader.ReadToEndAsync();
                        return JsonConvert.DeserializeObject<T>(responseFromServer);
                    }
                }
            }
        }
    }
}
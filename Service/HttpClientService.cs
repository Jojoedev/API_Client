using Api_Client.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Api_Client.Service
{
    [ApiController]
     public class HttpClientService : IHttpInterface
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<T> GetData<T>()
        {
            T result = default(T);


            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://api.publicapis.org/entries");

            if (response.IsSuccessStatusCode)
            {
                 result = await response.Content.ReadFromJsonAsync<T>().ConfigureAwait(false);
               // result = JsonConvert.DeserializeObject<T>(content);
            }

            return result;
            /*var response = new HttpRequestMessage(HttpMethod.Get, "https://api.publicapis.org/entries")
            {
             Header
            {
            {HeadersName.Accept, "application/json"},
            {HeadesName.UserAgent, "RequestMessageSample"}
            }


            };*/

        }

        

        public Task<T> CreateData<T>(T body)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteData<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAData<T>(int id)
        {
            throw new NotImplementedException();
        }

        

        public Task<T> UpdateData<T>(int id, T body)
        {
            throw new NotImplementedException();
        }
    }
}

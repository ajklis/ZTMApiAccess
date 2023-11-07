using ZTMApiAccess.Interfaces;

namespace ZTMApiAccess.Connections
{
    class HttpAccess : IHttpAccess
    {
        HttpClient client;

        public HttpAccess()
        {
            client = new HttpClient();
        }
        
        public async Task<HttpResponseMessage> ExecuteGetRequest(string url)
        {
            return await client.GetAsync(url);
        }
    }
}
namespace ZTMApiAccess.Interfaces
{
    interface IHttpAccess
    {
        public Task<HttpResponseMessage> ExecuteGetRequest(string url);
    }
}
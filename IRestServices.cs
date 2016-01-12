using System.Collections.Generic;

namespace RestKit
{
    public interface IRestServices
    {
        string HttpGet(string url,  Dictionary<string, string> parameters);
        string HttpPost(string url,  Dictionary<string, string> parameters);
    }
}

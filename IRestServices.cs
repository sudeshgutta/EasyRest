using RestKit.Model;
using System.Collections.Generic;

namespace RestKit
{
    public interface IRestServices
    {
        CustomResponse  HttpGet(string url, Dictionary<string, string> parameters = null);
        CustomResponse HttpPost(string url, Dictionary<string, string> parameters = null);
    }
}

using RestSharp;
using System;
using System.Collections.Generic;

namespace RestKit
{
    /// <summary>
    /// Handles Http Requests and Http Responses
    /// </summary>
    public class RestServices :IRestServices
    {
       
        private string HttpRequest(IRestRequest request,string url, Dictionary<string, string> parameters)
        {
            IRestClient client = new RestClient();
            IRestResponse response = new RestResponse();

            client.BaseUrl = new Uri(url);
            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            
            response = client.Execute(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return response.Content;
            }
            return null;
        }
        /// <summary>
        /// Sends a Http GET call to API, with specified parameters
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string HttpGet(string url,  Dictionary<string,string> parameters)
        {
            IRestRequest request = new RestRequest();
            request.Method = Method.GET;
            return HttpRequest(request,url, parameters);
        }
        /// <summary>
        /// Sends a Http POST call to API, with specified parameters
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string HttpPost(string url,  Dictionary<string, string> parameters)
        {
            IRestRequest request = new RestRequest();
            request.Method = Method.POST;
            return HttpRequest(request, url, parameters);
        }
    }
}

using RestKit.Model;
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

        private CustomResponse HttpRequest(IRestRequest request, string url, Dictionary<string, string> parameters = null)
        {
            try
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
                var myResponse = new CustomResponse();
                myResponse.StatusCode = response.StatusCode;
                myResponse.Content = response.Content;
                return myResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// Sends a Http GET call to API, with specified parameters
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public CustomResponse HttpGet(string url, Dictionary<string, string> parameters = null)
        {
            try
            {
                IRestRequest request = new RestRequest();
                request.Method = Method.GET;
                return HttpRequest(request, url, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sends a Http POST call to API, with specified parameters
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public CustomResponse HttpPost(string url, Dictionary<string, string> parameters = null)
        {
            try
            {
                IRestRequest request = new RestRequest();
                request.Method = Method.POST;
                return HttpRequest(request, url, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

# RestKit
An easy to use wrapper for HTTP in C#

It's a wrapper over RestSharp (https://github.com/restsharp/RestSharp) which provides users an easy to use interface to perform HTTP requests and to read their responses 

Example Usage : 

 IRestServices restServices = new RestServices();
 string url = "http://localhost"
 Dictionary<string,string> para = new Dictionary<string,string>();
 para.Add("param1","param1");
 para.Add("param2","param2");
 string json = restServices.HttpGet(url, para);
 

At the current moment have implemented the wrapper for basic HTTP GET and POST requests, more work in progress...

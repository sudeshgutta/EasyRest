# SingleFuncRest
An easy to use wrapper for HTTP/Rest API consumption in C#

<b>License: Apache License 2.0</b>

It's a wrapper over RestSharp (https://github.com/restsharp/RestSharp) which provides users an easy to use interface to perform HTTP requests and to read their responses 

<br/>
Example Usage : 

 IRestServices restServices = new RestServices();<br/>
 string url = "http://localhost" <br/>
 Dictionary<string,string> para = new Dictionary<string,string>(); <br/>
 para.Add("param1","param1"); <br/>
 para.Add("param2","param2");<br/>
 string json = restServices.HttpGet(url, para);<br/>
 

At the current moment have implemented the wrapper for basic HTTP GET and POST requests, more work is in progress to enable consumption of rest services easily with a single function call.

using System.Net;
namespace RestKit.Model
{
   public class CustomResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Content { get; set; }
    }
}

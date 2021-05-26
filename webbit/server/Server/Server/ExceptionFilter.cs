using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;


namespace Server
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public Dictionary<int,HttpResponseMessage> Responses { get; set; }

        public ExceptionFilter()
        {
            Responses = new Dictionary<int, HttpResponseMessage> {{ new NullReferenceException().HResult, new HttpResponseMessage(HttpStatusCode.NotFound) }};
        }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            try
            {
                actionExecutedContext.Response = Responses[actionExecutedContext.Exception.HResult];
            }
            catch(KeyNotFoundException)
            {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using AngularDemo.Shared;
namespace AngularDemo.APIServices.Controllers
{
    
    
    [ExceptionAspect]
    public abstract class BaseController : ApiController, IExceptionFilter,IActionFilter
    {
        
        public bool AllowMultiple
        {
            get
            {
                throw new NotImplementedException();
            }
        }
       
        [MethodAspect]
        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

       
    }
}

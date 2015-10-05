using System;
using System.Web;
using System.Web.Routing;
using System.Web.WebPages;

namespace AngularDemo.Web.Routing
{
    public class DefaultRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return WebPageHttpHandler.CreateFromVirtualPath("~/Views/index.cshtml");
        }
    }
}
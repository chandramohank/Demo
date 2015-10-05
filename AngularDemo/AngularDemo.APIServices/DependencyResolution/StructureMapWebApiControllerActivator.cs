using StructureMap;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace AngularDemo.APIServices.DependencyResolution
{
    public class StructureMapWebApiControllerActivator : IHttpControllerActivator
    {
        private readonly IContainer _container;
        public StructureMapWebApiControllerActivator(IContainer container)
        {
            _container = container;
        }
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return (IHttpController)this._container.GetInstance(controllerType);
        }
    }
}
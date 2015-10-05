using AngularDemo.Data;
using AngularDemo.Data.Repositories;
using AngularDemo.Data.Repositories.AdventuresDemo;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Services;
using AngularDemo.APIServices.Mappers;
using System.Web.Http.Dispatcher;
using AngularDemo.APIServices.DependencyResolution;
using System.Web;

namespace AngularDemo.APIServices.App_Start
{
    public static class Bootstrapper
    {
        public static void Configure()
        {
            //ConfigureAutofacContainer();
            ConfigureStructureMapContainer();
            AutoMapperConfiguration.Configure();
            ConfigLog4Net();
        }

        public static void ConfigureAutofacContainer()
        {
            var webApiContainerBuilder = new ContainerBuilder();
            ConfigureWebApiContainer(webApiContainerBuilder);           
        }
        public static void ConfigureStructureMapContainer()
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;
            StructureMap.IContainer container = new StructureMap.Container(c => c.AddRegistry<DefaultRegistry>());
            config.Services.Replace(
                typeof(IHttpControllerActivator),
                new StructureMapWebApiControllerActivator(container));            
        }
        public static void ConfigureWebApiContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            containerBuilder.RegisterType<DashboardRepository>().As<IDashboardRepository>();
            containerBuilder.RegisterType<DashboardService>().As<IDashboardService>();

            containerBuilder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());
            IContainer container = containerBuilder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
        public static void ConfigLog4Net()
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(HttpContext.Current.Server.MapPath("~/log4net.config")));
        }
    }
}
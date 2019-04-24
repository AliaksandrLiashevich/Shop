using System;
using System.Linq;
using System.Threading;
using Autofac;
using Autofac.Integration.Mvc;
using DependencyResolver;

namespace Shop.App_Start
{
    public class InjectorConfig
    {
        public static void RegisterInjector()
        {
            var builder = new ContainerBuilder();

            DIConfig.Register(builder);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
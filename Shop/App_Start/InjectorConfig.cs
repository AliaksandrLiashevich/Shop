using System;
using System.Linq;
using System.Threading;
using Autofac;
using Autofac.Integration.Mvc;

namespace Shop.App_Start
{
    public class InjectorConfig
    {
        public static void RegisterInjector()
        {
            var builder = new ContainerBuilder();
            
            var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Dependency")).ToArray();
            var all = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyModules(assembly);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
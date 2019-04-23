using System;
using System.Linq;
using Autofac;
using Autofac.Integration.Mvc;

namespace Shop.App_Start
{
    public class InjectorConfig
    {
        public static void RegisterInjector()
        {
            var builder = new ContainerBuilder();
            var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Shop")).ToArray();

            builder.RegisterAssemblyModules(assembly);

            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
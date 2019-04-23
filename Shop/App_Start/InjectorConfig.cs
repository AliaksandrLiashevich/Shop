using System;
using System.Web.Mvc;
using Autofac;

namespace Shop.App_Start
{
    public class IjectorConfig
    {
        public static void RegisterInjector()
        {
            var builder = new ContainerBuilder();
            var assembly = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyModules(assembly);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
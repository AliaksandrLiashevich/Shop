using System;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace Shop.App_Start
{
    public class InjectorConfig
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
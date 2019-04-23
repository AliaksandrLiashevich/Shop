using System;
using System.Linq;

namespace Shop.App_Start
{
    public class MapperInitializer
    {
        public static void Initialize()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Web")).ToArray();

            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfiles(assemblies));
        }
    }
}
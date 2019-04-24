using Autofac;
using BLL.Interfaces.Services;
using BLL.Services;
using DAL.EFConfigurations;
using DAL.Interfaces.Repositories;
using DAL.Repositories;

namespace DependencyResolver 
{
    public static class DIConfig
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<ShopContext>();
            builder.RegisterType<CartRepository>().As<ICartRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CartProductRepository>().As<ICartProductRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CartService>().As<ICartService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CartProductService>().As<ICartProductService>();
            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}

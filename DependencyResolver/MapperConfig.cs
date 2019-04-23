using AutoMapper;
using BLL.Interfaces.Models;
using DAL.Interfaces.Entities;
using Shop.Models;

namespace DependencyResolver
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Cart, CartDb>();
            CreateMap<CartProduct, CartProductDb>();
            CreateMap<Product, ProductDb>();
            CreateMap<User, UserDb>();

            CreateMap<CartDb, Cart>();
            CreateMap<CartProductDb, CartProduct>();
            CreateMap<ProductDb, Product>();
            CreateMap<UserDb, User>();

            CreateMap<LoginModel, User>();
            CreateMap<RegisterModel, User>();
            CreateMap<CartViewModel, Cart>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<User, LoginModel>();
            CreateMap<User, RegisterModel>();
            CreateMap<Cart, CartViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}

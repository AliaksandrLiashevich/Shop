using AutoMapper;
using BLL.Interfaces.Models;
using DAL.Interfaces.Entities;

namespace DependencyResolver
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Cart, CartDb>();
            CreateMap<CartProduct, CartProductDb>();
            CreateMap<Product, ProductDb>();

            CreateMap<CartDb, Cart>();
            CreateMap<CartProductDb, CartProduct>();
            CreateMap<ProductDb, Product>();
        }
    }
}

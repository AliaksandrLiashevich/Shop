using AutoMapper;
using BLL.Interfaces.Models;
using Shop.Models;

namespace Shop.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LoginModel, User>();
            CreateMap<RegisterModel, User>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<User, LoginModel>();
            CreateMap<User, RegisterModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}
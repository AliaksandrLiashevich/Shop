using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using DAL.Interfaces.Entities;
using DAL.Interfaces.Repositories;

namespace BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;

        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }

        public async Task AddCartAsync(Cart cart)
        {
            //нужна валидация модели

            var dbCart = Mapper.Map<CartDb>(cart);

            await _repository.AddCartAsync(dbCart);
        }

        public async Task<Cart> GetByIdAsync(int id)
        {
            var dbCart = await _repository.GetByIdAsync(id);

            return Mapper.Map<Cart>(dbCart);
        }

        public async Task<List<Cart>> GetAllCartsAsync()
        {
            var dbCart = await _repository.GetAllCartsAsync();

            return Mapper.Map<List<Cart>>(dbCart);
        }

        public async Task DeleteCartAsync(int id)
        {
            await _repository.DeleteCart(id);
        }
    }
}

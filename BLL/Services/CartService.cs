using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
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
            //тут нужен маппинг из Cart в dbCart
            //_repository.AddCartAsync();


        }

        public async Task<Cart> GetByIdAsync(int id)
        {
            var dbCart = await _repository.GetByIdAsync(id);

            //тут нужен маппинг из dbCart в Cart

            return new Cart();
        }

        public async Task<List<Cart>> GetAllCartsAsync()
        {
            var dbCart = await _repository.GetAllCartsAsync();

            //тут нужен маппинг из dbCart в Cart

            return new List<Cart>();
        }

        public async Task DeleteCartAsync(int id)
        {
            await _repository.DeleteCart(id);
        }
    }
}

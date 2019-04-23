using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using DAL.Interfaces.Repositories;

namespace BLL.Services
{
    public class CartProductService : ICartProductService
    {
        private readonly ICartProductRepository _repository;

        public CartProductService(ICartProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddCartProductAsync(CartProduct cartProduct)
        {
            //нужен маппинг
            //await _repository.AddCartProductAsync();
        }

        public async Task<CartProduct> GetByIdAsync(int cartId, int productId)
        {
            var dbCart = await _repository.GetByIdAsync(cartId, productId);

            //тут нужен маппинг

            return new CartProduct();
        }

        public async Task<List<CartProduct>> GetAllCartProductsAsync()
        {
            var dbCart = await _repository.GetAllCartProductsAsync();

            //тут нужен маппинг из dbCart в Cart

            return new List<CartProduct>();
        }

        public async Task DeleteCartProductAsync(int cartId, int productId)
        {
            await _repository.DeleteCart(cartId, productId);
        }
    }
}

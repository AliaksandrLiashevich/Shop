using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using DAL.Interfaces.Entities;
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
            var cartProductDb = Mapper.Map<CartProductDb>(cartProduct);

            await _repository.AddCartProductAsync(cartProductDb);
        }

        public async Task<CartProduct> GetByIdAsync(int cartId, int productId)
        {
            var dbCartProduct = await _repository.GetByIdAsync(cartId, productId);

            return Mapper.Map<CartProduct>(dbCartProduct);
        }

        public async Task<List<CartProduct>> GetAllCartProductsAsync()
        {
            var dbCartProduct = await _repository.GetAllCartProductsAsync();

            return Mapper.Map<List<CartProduct>>(dbCartProduct);
        }

        public async Task DeleteCartProductAsync(int cartId, int productId)
        {
            await _repository.DeleteCart(cartId, productId);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using DAL.Interfaces.Entities;
using DAL.Interfaces.Repositories;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddProductAsync(Product product)
        {
            var dbProduct = Mapper.Map<ProductDb>(product);

            await _repository.AddProductAsync(dbProduct);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var dbProduct = await _repository.GetByIdAsync(id);

            return Mapper.Map<Product>(dbProduct);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var dbProducts = await _repository.GetAllProductsAsync();

            return Mapper.Map<List<Product>>(dbProducts);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _repository.DeleteProduct(id);
        }
    }
}

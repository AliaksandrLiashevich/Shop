using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
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
            //нужен маппинг
            //await _repository.AddProductAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var dbProduct = await _repository.GetByIdAsync(id);

            //нужен маппинг

            return new Product();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var dbProducts = await _repository.GetAllProductsAsync();

            //нужен маппинг

            return new List<Product>();
        }

        public async Task DeleteProductAsync(int id)
        {
            await _repository.DeleteProduct(id);
        }

    }
}

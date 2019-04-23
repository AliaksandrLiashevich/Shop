using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;

namespace BLL.Interfaces.Services
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);

        Task<Product> GetByIdAsync(int id);

        Task<List<Product>> GetAllProductsAsync();

        Task DeleteProductAsync(int id);
    }
}

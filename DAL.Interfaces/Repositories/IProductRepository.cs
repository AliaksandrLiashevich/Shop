using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Interfaces.Entities;

namespace DAL.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task AddProductAsync(ProductDb model);

        Task<ProductDb> GetByIdAsync(int id);

        Task<List<ProductDb>> GetAllProductsAsync();

        Task DeleteProduct(int id);
    }
}

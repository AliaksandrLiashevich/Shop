using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Interfaces.Entities;

namespace DAL.Interfaces.Repositories
{
    public interface ICartProductRepository
    {
        Task AddCartProductAsync(CartProductDb model);

        Task<CartProductDb> GetByIdAsync(int cartId, int productId);

        Task<List<CartProductDb>> GetAllCartProductsAsync();

        Task DeleteCart(int cartId, int productId);
    }
}

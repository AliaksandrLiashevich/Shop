using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;

namespace BLL.Interfaces.Services
{
    public interface ICartProductService
    {
        Task AddCartProductAsync(CartProduct cartProduct);

        Task<CartProduct> GetByIdAsync(int cartId, int productId);

        Task<List<CartProduct>> GetAllCartProductsAsync();

        Task DeleteCartProductAsync(int cartId, int productId);
    }
}

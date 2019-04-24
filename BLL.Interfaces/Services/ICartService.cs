using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;

namespace BLL.Interfaces.Services
{
    public interface ICartService
    {
        Task AddCartAsync(string userName);

        Task<Cart> GetByIdAsync(int id);

        Task<List<Cart>> GetAllCartsAsync();

        Task DeleteCartAsync(int id);
    }
}

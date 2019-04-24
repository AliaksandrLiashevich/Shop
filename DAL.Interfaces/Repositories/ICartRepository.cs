using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Interfaces.Entities;

namespace DAL.Interfaces.Repositories
{
    public interface ICartRepository
    {
        Task AddCartAsync(string userName);

        Task<CartDb> GetByIdAsync(int id);

        Task<List<CartDb>> GetAllCartsAsync();

        Task DeleteCart(int id);
    }
}

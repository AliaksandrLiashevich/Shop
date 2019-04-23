using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Interfaces.Entities;

namespace DAL.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(UserDb model);

        Task<UserDb> GetByIdAsync(int id);

        Task<List<UserDb>> GetAllUsersAsync();

        Task DeleteUser(int id);
    }
}

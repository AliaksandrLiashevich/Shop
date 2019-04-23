
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces.Models;

namespace BLL.Interfaces.Services
{
    public interface IUserService
    {
        Task AddUserAsync(User user);

        Task<User> GetByIdAsync(int id);

        Task<List<User>> GetAllUsersAsync();

        Task DeleteUserAsync(int id);
    }
}

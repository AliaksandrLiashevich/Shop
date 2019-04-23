using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces.Models;
using BLL.Interfaces.Services;
using DAL.Interfaces.Entities;
using DAL.Interfaces.Repositories;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task AddUserAsync(User user)
        {
            var dbUser = Mapper.Map<UserDb>(user);

            await _repository.AddUserAsync(dbUser);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var dbUser = await _repository.GetByIdAsync(id);

            return Mapper.Map<User>(dbUser);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var dbUsers = await _repository.GetAllUsersAsync();

            return Mapper.Map<List<User>>(dbUsers);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _repository.DeleteUser(id);
        }
    }
}

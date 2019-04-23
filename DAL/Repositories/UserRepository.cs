using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DAL.EFConfigurations;
using DAL.Interfaces.Entities;
using DAL.Interfaces.Exceptions;
using DAL.Interfaces.Repositories;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShopContext _context;

        public UserRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(UserDb model)
        {
            if (model == null)
            {
                throw new DatabaseException(DatabaseException.ErrorType.InvalidArgument);
            }

            _context.UsersDb.Add(model);

            await _context.SaveChangesAsync();
        }
        public async Task<UserDb> GetByIdAsync(int id)
        {
            var dbUsers = await _context.UsersDb.Where(p => p.Id == id).ToListAsync();

            if (dbUsers.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any user");
            }

            return dbUsers[0];
        }

        public async Task<List<UserDb>> GetAllUsersAsync()
        {
            return await _context.UsersDb.ToListAsync();
        }

        public async Task DeleteUser(int id)
        {
            var dbUsers = await _context.UsersDb.Where(p => p.Id == id).ToListAsync();

            if (dbUsers.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any user");
            }

            var dbUser = dbUsers[0];

            _context.UsersDb.Remove(dbUser);

            await _context.SaveChangesAsync();
        }
    }
}

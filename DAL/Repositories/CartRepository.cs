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
    public class CartRepository : ICartRepository
    {
        private readonly ShopContext _context;

        public CartRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task AddCartAsync(CartDb model)
        {
            if (model == null)
            {
                throw new DatabaseException(DatabaseException.ErrorType.InvalidArgument);
            }

            _context.CartsDB.Add(model);

            await _context.SaveChangesAsync();
        }

        public async Task<CartDb> GetByIdAsync(int id)
        {
            var dbCarts = await _context.CartsDB.Where(c => c.Id == id).ToListAsync();

            if (dbCarts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any cart");
            }

            return dbCarts[0];
        }

        public async Task<List<CartDb>> GetAllCartsAsync()
        {
            return await _context.CartsDB.ToListAsync();
        }

        public async Task DeleteCart(int id)
        {
            var dbCarts = await _context.CartsDB.Where(c => c.Id == id).ToListAsync();

            if (dbCarts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any product");
            }

            var dbCart = dbCarts[0];

            _context.CartsDB.Remove(dbCart);

            await _context.SaveChangesAsync();
        }
    }
}

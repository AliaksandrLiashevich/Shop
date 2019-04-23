using DAL.EFConfigurations;
using DAL.Interfaces.Entities;
using DAL.Interfaces.Exceptions;
using DAL.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CartProductRepository : ICartProductRepository
    {
        private readonly ShopContext _context;

        public CartProductRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task AddCartProductAsync(CartProductDb model)
        {
            if (model == null)
            {
                throw new DatabaseException(DatabaseException.ErrorType.InvalidArgument);
            }

            _context.CartProductsDB.Add(model);

            await _context.SaveChangesAsync();
        }

        public async Task<CartProductDb> GetByIdAsync(int cartId, int productId)
        {
            var dbCartProducts = await _context.CartProductsDB.Where(cp => cp.CartId == cartId && cp.ProductId == productId).ToListAsync();

            if (dbCartProducts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any cart product");
            }

            return dbCartProducts[0];
        }

        public async Task<List<CartProductDb>> GetAllCartProductsAsync()
        {
            return await _context.CartProductsDB.ToListAsync();
        }

        public async Task DeleteCart(int cartId, int productId)
        {
            var dbCartProducts = await _context.CartProductsDB.Where(cp => cp.CartId == cartId && cp.ProductId == productId).ToListAsync();

            if (dbCartProducts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any cart product");
            }

            var dbCartProduct = dbCartProducts[0];

            _context.CartProductsDB.Remove(dbCartProduct);

            await _context.SaveChangesAsync();
        }
    }
}

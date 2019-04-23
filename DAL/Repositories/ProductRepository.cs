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
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(ProductDb model)
        {
            if (model == null)
            {
                throw new DatabaseException(DatabaseException.ErrorType.InvalidArgument);
            }

            _context.ProductsDB.Add(model);

            await _context.SaveChangesAsync();
        }

        public async Task<ProductDb> GetByIdAsync(int id)
        {
            var dbProducts = await _context.ProductsDB.Where(p => p.Id == id).ToListAsync();

            if (dbProducts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any product");
            }

            return dbProducts[0];
        }

        public async Task<List<ProductDb>> GetAllProductsAsync()
        {
            return await _context.ProductsDB.ToListAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var dbProducts = await _context.ProductsDB.Where(p => p.Id == id).ToListAsync();

            if (dbProducts.Count != 0)
            {
                throw new DatabaseException(DatabaseException.ErrorType.WrongId,
                    "This id doesn't match any product");
            }

            var dbProduct = dbProducts[0];

            _context.ProductsDB.Remove(dbProduct);

            await _context.SaveChangesAsync();
        }
    }
}

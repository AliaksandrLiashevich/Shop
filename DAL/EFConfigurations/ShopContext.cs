using System.Data.Entity;
using DAL.EntitiesConfigurations;
using DAL.Interfaces.Entities;

namespace DAL.EFConfigurations
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("InternetShop")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<CartDb> CartsDB { get; set; }

        public DbSet<ProductDb> ProductsDB { get; set; }

        public DbSet<CartProductDb> CartProductsDB { get; set; }

        public DbSet<UserDb> UsersDb { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CartDbConfiguration());
            modelBuilder.Configurations.Add(new CartProductDbConfiguration());
            modelBuilder.Configurations.Add(new ProductDbConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

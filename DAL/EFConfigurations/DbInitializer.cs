using System.Data.Entity;
using DAL.Interfaces.Entities;

namespace DAL.EFConfigurations
{
    public class DbInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            //Please put data here

            context.SaveChanges();
        }
    }
}

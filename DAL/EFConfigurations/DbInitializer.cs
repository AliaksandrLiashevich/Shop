using System.Data.Entity;

namespace DAL.EFConfigurations
{
    public class DbInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            //Please, add data in this section

            base.Seed(context);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using DAL.Interfaces.Entities;

namespace DAL.EntitiesConfigurations
{
    public class CartDbConfiguration : EntityTypeConfiguration<CartDb>
    {
        public CartDbConfiguration()
        {
            this.ToTable("tbl_cart").HasKey(cart => cart.Id);
            this.Property(cart => cart.Id).HasColumnName("cln_id");
            this.Property(cart => cart.Quantity).HasColumnName("cln_quantity");
        }
    }
}

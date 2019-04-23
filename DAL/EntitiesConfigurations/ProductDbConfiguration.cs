using System.Data.Entity.ModelConfiguration;
using DAL.Interfaces.Entities;

namespace DAL.EntitiesConfigurations
{
    public class ProductDbConfiguration : EntityTypeConfiguration<ProductDb>
    {
        public ProductDbConfiguration()
        {
            this.ToTable("tbl_product").HasKey(product => product.Id);
            this.Property(product => product.Id).HasColumnName("cln_id");
            this.Property(product => product.Name).HasColumnName("cln_name");
            this.Property(product => product.Description).HasColumnName("cln_description");
            this.Property(product => product.Price).HasColumnName("cln_price");
        }
    }
}

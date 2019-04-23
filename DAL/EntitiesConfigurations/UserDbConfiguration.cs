using DAL.Interfaces.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EntitiesConfigurations
{
    public class UserDbConfiguration : EntityTypeConfiguration<UserDb>
    {
        public UserDbConfiguration()
        {
            this.ToTable("tbl_user").HasKey(user => user.Id);
            this.Property(user => user.Id).HasColumnName("cln_id");
            this.Property(user => user.Name).HasColumnName("cln_name");
            this.Property(user => user.Password).HasColumnName("cln_password");

            this.HasOptional<CartDb>(user => user.CartDb)
                .WithRequired(cart => cart.UserDb);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using DAL.Interfaces.Entities;

namespace DAL.EntitiesConfigurations
{
    public class CartProductDbConfiguration : EntityTypeConfiguration<CartProductDb>
    {
        public CartProductDbConfiguration()
        {
            this.ToTable("tbl_cart_product").HasKey(cartProduct => new { cartProduct.CartId, cartProduct.ProductId });
            this.Property(cartProduct => cartProduct.CartId).HasColumnName("cln_card_id");
            this.Property(cartProduct => cartProduct.ProductId).HasColumnName("cln_product_id");

            this.HasRequired<CartDb>(cartProduct => cartProduct.CartDB)
                .WithMany(cart => cart.CartProductsDB)
                .HasForeignKey(cartProduct => cartProduct.CartId);

            this.HasRequired<ProductDb>(cartProduct => cartProduct.ProductDB)
                .WithMany(product => product.CartProductsDB)
                .HasForeignKey(cartProduct => cartProduct.ProductId);
        }
    }
}

using System.Collections.Generic;

namespace DAL.Interfaces.Entities
{
    public class CartDb
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public virtual UserDb UserDb { get; set; }

        public virtual ICollection<CartProductDb> CartProductsDB { get; set; }
    }
}

using System.Collections.Generic;

namespace DAL.Interfaces.Entities
{
    public class ProductDb
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<CartProductDb> CartProductsDB { get; set; }
    }
}

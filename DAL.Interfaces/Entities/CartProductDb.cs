namespace DAL.Interfaces.Entities
{
    public class CartProductDb
    {
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public virtual CartDb CartDB { get; set; }

        public virtual ProductDb ProductDB { get; set; }
    }
}

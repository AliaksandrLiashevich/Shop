using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
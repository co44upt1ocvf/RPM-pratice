using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Posudomoika.Models
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }

        public required string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Price { get; set; }

        public required int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public required CategoryModel Category { get; set; }

        public required List<OrderItemModel> OrderItems { get; set; }
        public required List<CartItemModel> CartItems { get; set; }
    }
}

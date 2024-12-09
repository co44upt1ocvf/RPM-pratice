using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Posudomoika.Models
{
    public class CartItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int UserId { get; set; }

        public required int ProductId { get; set; }

        public required int Quantity { get; set; }

        [ForeignKey("UserId")]
        public required UserModel User { get; set; }

        [ForeignKey("ProductId")]
        public required ProductModel Product { get; set; }
    }
}

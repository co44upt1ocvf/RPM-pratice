using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Posudomoika.Models
{
    public class OrderItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int OrderId { get; set; }

        public required int ProductId { get; set; }

        public required int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public required OrderModel Order { get; set; }

        [ForeignKey("ProductId")]
        public required ProductModel Product { get; set; }
    }
}

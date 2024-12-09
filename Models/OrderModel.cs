using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Posudomoika.Models
{
    public class OrderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int UserId { get; set; }

        public required DateTime OrderDate { get; set; }

        [ForeignKey("UserId")]
        public required UserModel User { get; set; }

        public required List<OrderItemModel> OrderItems { get; set; }
    }
}

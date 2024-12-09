using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Posudomoika.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public required string Username { get; set; }

        public required string PasswordHash { get; set; }

        [MaxLength(20)]
        public required string Role { get; set; }

        public required List<OrderModel> Orders { get; set; }
        public required List<CartItemModel> CartItems { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Sum { get; set; }
        public virtual User User { get; set; }
        public virtual List<OrderProducts> OrderProducts { get; set; }
    }
}

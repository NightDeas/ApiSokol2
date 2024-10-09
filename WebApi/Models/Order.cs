using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}

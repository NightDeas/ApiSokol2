using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsClient { get; set; }
        public bool IsProvider { get; set; }
        public decimal? Discount { get; set; }
        public string FIO { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

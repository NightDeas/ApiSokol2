using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TypeId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public virtual TypeProduct TypeProduct { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }

    }
}

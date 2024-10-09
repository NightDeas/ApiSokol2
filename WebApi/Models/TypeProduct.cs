using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class TypeProduct
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

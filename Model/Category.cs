using System.ComponentModel.DataAnnotations;

namespace supermarketsys.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public String Name { get; set; }=string.Empty;
        public String? Description { get; set; } = string.Empty;

    }
}

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string  Name { get; set; }
        [MaxLength(800)]
        public string? CategoryPhoto { get; set; }
        public string? CategoryIcon { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

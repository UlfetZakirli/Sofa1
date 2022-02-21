using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductPhoto:BaseEntity
    {
        [MaxLength(600)]
        public string PhotoUrl { get; set; }
        public int? ProductID { get; set; }  
        public virtual Product? Product { get; set; } 

    }
}

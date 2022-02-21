using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public bool IsFeatured { get; set; }
        public decimal? Rating { get; set; }
        public string? PhotoUrl { get; set; }
        public ushort InStock { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSlider { get; set; }
        public bool IsWeek { get; set; }
        public bool IsMonth { get; set; }
        public int Quantity { get; set; }
        public string? SKU { get; set; }
        public int ThumbnailPictureId { get; set; }
        public string? Barcode { get; set; }

        public int? CategoryID { get; set; } 
        public virtual Category? Category { get; set; }   

    }
}

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Order : BaseEntity
    {

        [MaxLength(50)]
        public string CustomerName { get; set; }
        [MaxLength(15)]
        public string CustomerPhone { get; set; }
        [MaxLength(80)]
        public string CustomerEmail { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        public string CustomerID { get; set; }  
        public string CustomerAddress { get; set; }
        public decimal TotalAmount { get; set; } 
        public decimal? Discount { get; set; }
        public decimal FinalAmount { get; set; }
        public DateTime PlacedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime ModifieOn { get; set; }
        public bool IsRefunded { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        [MaxLength(100)]
        public string OrderCode { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }

}


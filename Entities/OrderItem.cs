using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderItem:BaseEntity
    {
        public decimal itemPrice { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public ushort Quantiy { get; set; }
        public decimal Price { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }

}


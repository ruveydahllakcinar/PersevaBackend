using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        
        public string? DiscountCode { get; set; }

        
        public DateTime DiscountDateCreated { get; set; }

        
        public string? DiscountType { get; set; }

        
        public string? DiscountCurrency { get; set; }

        
        public string? DiscountNumAvailable { get; set; }

        
        public string? DiscountNumUsed { get; set; }

        
        public DateTime DiscountExpiresAt { get; set; }

        public IList<Product>? Products { get; set; }
        public IList<Order>? Orders { get; set; }
    }
}

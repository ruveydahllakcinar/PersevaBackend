using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Refund
    {
        [Key]
        public int RefundId { get; set; }

       
        public string? RefundType { get; set; }

        
        public string?   Status { get; set; }

        
        public string? RefundStatus { get; set; }

        
        public string? PaymentStatus { get; set; }

        
        public DateTime RefundDateCreated { get; set; }

        
        public DateTime DateCreated { get; set; }

        public DateTime? RefundDateRefunded { get; set; }

        
        public string? Currency { get; set; }

        
        public double RefundTotal { get; set; }

        
        public string? PaymentMethod { get; set; }

        
        public decimal TotalPrice { get; set; }

        public string? Note { get; set; }
 

        public IList<Order>? Orders { get; set; }

        public Return? Return { get; set; }
    }

}

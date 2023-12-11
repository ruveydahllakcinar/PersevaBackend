using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        
        public string? Status { get; set; }

        
        public string? PaymentStatus { get; set; }

        
        public DateTime DateCreated { get; set; }

        
        public string? Currency { get; set; }

        
        public string? PaymentMethod { get; set; }

        
        public decimal TotalPrice { get; set; }

        public string? Note { get; set; }

        
        public string? FirstName { get; set; }

        
        public string? LastName { get; set; }

        
        public string? Email { get; set; }

        
        public string? Phone { get; set; }

        
        public string? Company { get; set; }

        
        public string? Address { get; set; }

        
        public string? District { get; set; }

        
        public string? City { get; set; }

        
        public string? Postcode { get; set; }

        
        public string? Country { get; set; }

        
        public int DiscountId { get; set; }
        public Discount? Discount { get; set; }
       

        
        public int BillingId { get; set; }
        public BillingInfo? BillingInfo { get; set; }

        
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        
        public int FulfillmentsId { get; set; }
        public Fulfillment? Fulfillments { get; set; }
        
        
        public int RefundsId { get; set; }
        public Refund? Refund { get; set; }

        
        public int UserId { get; set; }
        public User? User { get; set; }


        
        public int CargoId { get; set; }
        public Cargo? Cargo { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class UserAddress
    {
        [Key]
        public int UserAddressId { get; set; }

        
        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        
        public string? City { get; set; }

        
        public string? PostalCode { get; set; }

        
        public string? Country { get; set; }

        
        public string? Phone { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        
        public string? Username { get; set; }

        
        public string? FirstName { get; set; }

        
        public string? LastName { get; set; }

        
        public string? Password { get; set; }

        
        public string?   Email { get; set; }

        // Navigation property for Address
        public IList<UserAddress>? userAddresses { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class ShopOwner
    {
        [Key]
        public int ShopOwnerId { get; set; }


        public string? Type { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxOffice { get; set; }
        public string? TaxNumber { get; set; }
        public string? BankAccountHolder { get; set; }
        public string? BankAccountIban { get; set; }
    }
}

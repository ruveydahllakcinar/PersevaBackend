using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class BillingInfo
    {
        [Key]
        public int BillingId { get; set; }
        public string? BillingFirstName { get; set; }
        public string? BillingLastName { get; set; }
        public string? BillingNationalId { get; set; }
        public string? BillingEmail { get; set; }
        public string? BillingPhone { get; set; }
        public string? BillingCompany { get; set; }
        public string? BillingTaxOffice { get; set; }
        public string? BillingTaxNumber { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingDistrict { get; set; }
        public string? BillingCity { get; set; }
        public int BillingPostcode { get; set; }
        public string? BillingCountry { get; set; }

        public IList<Order>? Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Cargo
    {
        [Key]
        public int CargoId { get; set; }
        public string? CargoStatus { get; set; }
        public string? CargoMethod { get; set; }  
        public string? CargoType { get; set; }
        public DateTime CargoDateCreated { get; set; }   
        public DateTime CargoDateDispatched { get; set; }     
        public string? CargoCompany { get; set; }   
        public string? CargoCode { get; set; }  
        public string? CargoTrackingNumber { get; set; } 
        public string? CargoTrackingUrl { get; set; }
        public string? CargoSize { get; set; }  
        public string? CargoSizeUnit { get; set; }   
        public decimal CargoWeight { get; set; } 
        public string? CargoWeightUnit { get; set; }
        public double CargoCost { get; set; }  
        public string? CargoCurrency { get; set; }

        public IList<Order>? Orders { get; set; }
    }

}

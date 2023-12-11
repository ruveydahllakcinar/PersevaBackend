using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Return
    {
        [Key]
        public int ReturnId { get; set; }

        // Return-related properties
        
        public string? ReturnType { get; set; }

        
        public string? Status { get; set; }

        
        public DateTime ReturnDateCreated { get; set; }

        public DateTime ReturnDateRefunded { get; set; }

        
        public string? Currency { get; set; }

        
        public double ReturnTotal { get; set; }

        public string? Note { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

       
        public int CargoId { get; set; }
        public Cargo? Cargo { get; set; }

    }
}

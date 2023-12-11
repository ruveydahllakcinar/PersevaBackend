using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public bool Status { get; set; }

        public Product? Product { get; set; }

        public Order? Order { get; set; }
    }
}

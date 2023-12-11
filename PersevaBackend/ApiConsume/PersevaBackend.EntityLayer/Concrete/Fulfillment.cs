using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Fulfillment
    {
        public int FulfillmentId { get; set; }
        public int CargoId { get; set; }
        public Cargo? Cargo { get; set; }
    }
}

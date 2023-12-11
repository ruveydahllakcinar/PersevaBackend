using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
        public string? CoverImage { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Stock { get; set; }


        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        //public int DiscountId { get; set; }
        //public Discount? Discount { get; set; }

        public IList<Order>? Orders { get; set; }
    }
}

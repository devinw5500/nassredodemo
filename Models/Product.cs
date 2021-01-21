using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductInOrder = new HashSet<ProductInOrder>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? BaseCost { get; set; }

        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
    }
}

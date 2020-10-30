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
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public decimal? BaseCost { get; set; } = null;

        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
    }
}
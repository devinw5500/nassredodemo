using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderProductList
    {
        public OrderProductList()
        {
            ProductInOrder = new HashSet<ProductInOrder>();
        }

        public int OrderProductListId { get; set; }
        public int OrderDetailsId { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
    }
}

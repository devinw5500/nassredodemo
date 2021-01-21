using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class ProductInOrder
    {
        public int ProductInOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

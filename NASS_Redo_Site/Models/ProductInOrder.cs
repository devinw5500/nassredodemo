using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductInOrder
    {
        public int ProductInOrderId { get; set; }
        public int OrderListId { get; set; }
        public int ProductOrderedId { get; set; }

        public virtual OrderProductList OrderList { get; set; }
        public virtual ProductOrderDetail ProductOrdered { get; set; }
    }
}

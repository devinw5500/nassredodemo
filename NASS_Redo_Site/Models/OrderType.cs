using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderType
    {
        public OrderType()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}

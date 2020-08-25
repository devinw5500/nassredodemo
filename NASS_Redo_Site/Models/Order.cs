using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ReportOnOrder = new HashSet<ReportOnOrder>();
        }

        public int OrderId { get; set; }
        public string OrderUid { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ReportOnOrder> ReportOnOrder { get; set; }
    }
}

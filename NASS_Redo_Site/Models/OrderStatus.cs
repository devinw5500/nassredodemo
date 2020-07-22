using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            StatusForOrder = new HashSet<StatusForOrder>();
        }

        public int OrderStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<StatusForOrder> StatusForOrder { get; set; }
    }
}

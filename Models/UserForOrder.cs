using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class UserForOrder
    {
        public int UserForOrderId { get; set; }
        public string AspnetuserId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }

        public virtual Order Order { get; set; }
    }
}

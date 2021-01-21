using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class OrderComment
    {
        public int OrderCommentId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
        public bool? Urgent { get; set; }
        public DateTime? Date { get; set; }
        public string UserSubmitted { get; set; }

        public virtual Order Order { get; set; }
    }
}

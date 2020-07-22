using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderComment
    {
        public int OrderCommentId { get; set; }
        public int OrderDetailsId { get; set; }
        public string Comment { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
    }
}

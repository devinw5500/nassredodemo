using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class DateSet
    {
        public int DateSetId { get; set; }
        public DateTime SetDate { get; set; }
        public DateTime RenewDate { get; set; }
        public int AddrId { get; set; }

        public virtual Address Addr { get; set; }
    }
}

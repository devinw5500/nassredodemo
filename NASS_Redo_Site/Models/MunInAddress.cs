using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class MunInAddress
    {
        public int MunInAddressId { get; set; }
        public int AddrId { get; set; }
        public int MunId { get; set; }

        public virtual Address Addr { get; set; }
        public virtual Municipality Mun { get; set; }
    }
}

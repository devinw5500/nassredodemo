using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductStatus
    {
        public ProductStatus()
        {
            ProductInfo = new HashSet<ProductInfo>();
        }

        public int ProductStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<ProductInfo> ProductInfo { get; set; }
    }
}

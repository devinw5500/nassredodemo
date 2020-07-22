using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductInfo
    {
        public int ProductInfoId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BaseCost { get; set; }
        public bool Inactive { get; set; }
        public string Type { get; set; }
        public int ProductStatusId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
    }
}

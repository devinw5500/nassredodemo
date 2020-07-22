using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductInList
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public int ListId { get; set; }

        public virtual RecProductList List { get; set; }
        public virtual Product Prod { get; set; }
    }
}

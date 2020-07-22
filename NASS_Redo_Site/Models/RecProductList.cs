using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class RecProductList
    {
        public RecProductList()
        {
            ProdListOrganization = new HashSet<ProdListOrganization>();
            ProductInList = new HashSet<ProductInList>();
        }

        public int Id { get; set; }

        public virtual ICollection<ProdListOrganization> ProdListOrganization { get; set; }
        public virtual ICollection<ProductInList> ProductInList { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProdListOrganization
    {
        public int Id { get; set; }
        public int ProdListId { get; set; }
        public int OrgId { get; set; }

        public virtual Organization Org { get; set; }
        public virtual RecProductList ProdList { get; set; }
    }
}

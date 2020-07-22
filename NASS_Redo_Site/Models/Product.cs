using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Product
    {
        public Product()
        {
            ProdInGroup = new HashSet<ProdInGroup>();
            ProductInList = new HashSet<ProductInList>();
            ProductInfo = new HashSet<ProductInfo>();
            ProductOrderDetail = new HashSet<ProductOrderDetail>();
            ReportOnProduct = new HashSet<ReportOnProduct>();
            WorkflowGroup = new HashSet<WorkflowGroup>();
        }

        public int ProductId { get; set; }

        public virtual ICollection<ProdInGroup> ProdInGroup { get; set; }
        public virtual ICollection<ProductInList> ProductInList { get; set; }
        public virtual ICollection<ProductInfo> ProductInfo { get; set; }
        public virtual ICollection<ProductOrderDetail> ProductOrderDetail { get; set; }
        public virtual ICollection<ReportOnProduct> ReportOnProduct { get; set; }
        public virtual ICollection<WorkflowGroup> WorkflowGroup { get; set; }
    }
}

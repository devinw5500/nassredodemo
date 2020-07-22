using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ProductOrderDetail
    {
        public ProductOrderDetail()
        {
            ProductInOrder = new HashSet<ProductInOrder>();
        }

        public int ProductOrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int? WorkflowId { get; set; }
        public decimal AdditionalFee { get; set; }

        public virtual Product Product { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
    }
}

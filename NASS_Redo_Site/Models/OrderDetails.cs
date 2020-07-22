using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            EmployeeOnOrder = new HashSet<EmployeeOnOrder>();
            OrderClient = new HashSet<OrderClient>();
            OrderComment = new HashSet<OrderComment>();
            OrderProductList = new HashSet<OrderProductList>();
            PropertyForOrder = new HashSet<PropertyForOrder>();
            SpecificationList = new HashSet<SpecificationList>();
            StatusForOrder = new HashSet<StatusForOrder>();
        }

        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalCost { get; set; }
        public int StatusId { get; set; }
        public int OrderTypeId { get; set; }
        public int TransactionTypeDetailsId { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderType OrderType { get; set; }
        public virtual TransactionTypeDetails TransactionTypeDetails { get; set; }
        public virtual ICollection<EmployeeOnOrder> EmployeeOnOrder { get; set; }
        public virtual ICollection<OrderClient> OrderClient { get; set; }
        public virtual ICollection<OrderComment> OrderComment { get; set; }
        public virtual ICollection<OrderProductList> OrderProductList { get; set; }
        public virtual ICollection<PropertyForOrder> PropertyForOrder { get; set; }
        public virtual ICollection<SpecificationList> SpecificationList { get; set; }
        public virtual ICollection<StatusForOrder> StatusForOrder { get; set; }
    }
}

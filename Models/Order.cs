using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class Order
    {
        public Order()
        {
            AddressInOrder = new HashSet<AddressInOrder>();
            OrderComment = new HashSet<OrderComment>();
            PersonInOrder = new HashSet<PersonInOrder>();
            ProductInOrder = new HashSet<ProductInOrder>();
            UserForOrder = new HashSet<UserForOrder>();
        }

        public int OrderId { get; set; }
        public string OrderGuid { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public DateTime? OrderEta { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }

        public virtual ICollection<AddressInOrder> AddressInOrder { get; set; }
        public virtual ICollection<OrderComment> OrderComment { get; set; }
        public virtual ICollection<PersonInOrder> PersonInOrder { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
        public virtual ICollection<UserForOrder> UserForOrder { get; set; }
    }
}

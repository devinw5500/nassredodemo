using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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

        [NotMapped]
        public int OrderId { get; set; }

        [NotMapped]
        public string OrderGuid { get; set; }

        public string Type { get; set; }
#nullable enable    //! Info: controlls nulability warnings and compieler control
        public string? Status { get; set; }
#nullable disable
        public decimal? TotalCost { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderEta { get; set; }

        public virtual ICollection<AddressInOrder> AddressInOrder { get; set; }
        public virtual ICollection<OrderComment> OrderComment { get; set; }

        [NotMapped]
        public virtual ICollection<PersonInOrder> PersonInOrder { get; set; }

        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
        public virtual ICollection<UserForOrder> UserForOrder { get; set; }

        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[Order] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}','{5}')", OrderId, OrderGuid, Status, TotalCost, OrderPlaced, OrderEta);

            return sqlInsertAddress.ToString();
        }
    }
}
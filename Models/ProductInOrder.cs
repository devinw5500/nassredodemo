using System;
using System.Collections.Generic;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class ProductInOrder
    {
        public int ProductInOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[PersonInOrder] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}')", ProductInOrderId, ProductId, OrderId, Order, Product);

            return sqlInsertAddress.ToString();
        }
    }
}

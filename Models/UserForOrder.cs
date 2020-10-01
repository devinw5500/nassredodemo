using System;
using System.Collections.Generic;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class UserForOrder
    {
        public int UserForOrderId { get; set; }
        public string AspnetuserId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }

        public virtual AspNetUsers Aspnetuser { get; set; }
        public virtual Order Order { get; set; }

        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[PersonInOrder] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}','{5}')", UserForOrderId, AspnetuserId, OrderId, Type, Aspnetuser, Order);

            return sqlInsertAddress.ToString();
        }
    }
}

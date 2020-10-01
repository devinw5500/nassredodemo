using System;
using System.Collections.Generic;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class AddressInOrder
    {
        public int AddressInOrder1 { get; set; }
        public int AddressId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }

        public virtual Address Address { get; set; }
        public virtual Order Order { get; set; }

        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[AddressInOrder] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}','{5}')", AddressInOrder1, AddressId, OrderId, Type, Address, Order);

            return sqlInsertAddress.ToString();
        }
    }
}
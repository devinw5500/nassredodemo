using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class PersonInOrder
    {
        public int PersonInOrder1 { get; set; }
        [NotMapped]
        public int PersonId { get; set; }
        [NotMapped]
        public int OrderId { get; set; }
        public string Type { get; set; }

        [NotMapped]
        public virtual Order Order { get; set; }
        public virtual PersonalInfo Person { get; set; }
        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[PersonInOrder] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}','{5}')", PersonInOrder1, PersonId, OrderId, Type, Order, Person);

            return sqlInsertAddress.ToString();
        }
    }
}

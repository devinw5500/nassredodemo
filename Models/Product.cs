using System;
using System.Collections.Generic;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductInOrder = new HashSet<ProductInOrder>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public decimal? BaseCost { get; set; } = null;

        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }

        public string ToSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[PersonInOrder] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}')", ProductId, Name, Description, BaseCost);

            return sqlInsertAddress.ToString();
        }
    }
}

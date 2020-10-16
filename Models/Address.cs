using System.Collections.Generic;
using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class Address
    {
        public Address()
        {
            AddressInOrder = new HashSet<AddressInOrder>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; } = null;
        public string AddressLine2 { get; set; } = null;
        public string StateAbbr { get; set; } = null;
        public string City { get; set; } = null;
        public string County { get; set; } = null;
        public string Zip { get; set; } = null;
        public string ParcelId { get; set; } = null;

        public virtual ICollection<AddressInOrder> AddressInOrder { get; set; }

        public string toSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[Address]([AddressLine1],[AddressLine2],[StateAbbr],[City],[County],[ZIP],[ParcelID]) VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", AddressLine1, AddressLine2, StateAbbr, City, County, Zip, ParcelId);

            return sqlInsertAddress.ToString();
        }
    }
}
using System.Collections.Generic;

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
    }
}
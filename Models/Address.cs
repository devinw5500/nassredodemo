using System;
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
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string StateAbbr { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public string ParcelId { get; set; }
        public string AssessedAmount { get; set; }

        public virtual ICollection<AddressInOrder> AddressInOrder { get; set; }
    }
}

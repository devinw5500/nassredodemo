using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Address
    {
        public Address()
        {
            AddressLine = new HashSet<AddressLine>();
            DateSet = new HashSet<DateSet>();
            ParcelId = new HashSet<ParcelId>();
            PersonInfo = new HashSet<PersonInfo>();
            PropertyForOrder = new HashSet<PropertyForOrder>();
            SchoolDistrict = new HashSet<SchoolDistrict>();
            SchoolInAddress = new HashSet<SchoolInAddress>();
        }

        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public int ZipId { get; set; }

        public virtual City City { get; set; }
        public virtual County County { get; set; }
        public virtual Zip Zip { get; set; }
        public virtual ICollection<AddressLine> AddressLine { get; set; }
        public virtual ICollection<DateSet> DateSet { get; set; }
        public virtual ICollection<ParcelId> ParcelId { get; set; }
        public virtual ICollection<PersonInfo> PersonInfo { get; set; }
        public virtual ICollection<PropertyForOrder> PropertyForOrder { get; set; }
        public virtual ICollection<SchoolDistrict> SchoolDistrict { get; set; }
        public virtual ICollection<SchoolInAddress> SchoolInAddress { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ReportDetails
    {
        public ReportDetails()
        {
            ReportDateDetails = new HashSet<ReportDateDetails>();
            ReportEmail = new HashSet<ReportEmail>();
            ReportOnClient = new HashSet<ReportOnClient>();
            ReportOnEmployee = new HashSet<ReportOnEmployee>();
            ReportOnOrder = new HashSet<ReportOnOrder>();
            ReportOnProduct = new HashSet<ReportOnProduct>();
            ReportOnTaxCol = new HashSet<ReportOnTaxCol>();
            ReportOnVendor = new HashSet<ReportOnVendor>();
            TypeOfReport = new HashSet<TypeOfReport>();
        }

        public int ReportDetailsId { get; set; }
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int ReportFromDateId { get; set; }
        public int ReportThroughDateId { get; set; }

        public virtual Report Report { get; set; }
        public virtual ReportFromDate ReportFromDate { get; set; }
        public virtual ReportThroughDate ReportThroughDate { get; set; }
        public virtual ICollection<ReportDateDetails> ReportDateDetails { get; set; }
        public virtual ICollection<ReportEmail> ReportEmail { get; set; }
        public virtual ICollection<ReportOnClient> ReportOnClient { get; set; }
        public virtual ICollection<ReportOnEmployee> ReportOnEmployee { get; set; }
        public virtual ICollection<ReportOnOrder> ReportOnOrder { get; set; }
        public virtual ICollection<ReportOnProduct> ReportOnProduct { get; set; }
        public virtual ICollection<ReportOnTaxCol> ReportOnTaxCol { get; set; }
        public virtual ICollection<ReportOnVendor> ReportOnVendor { get; set; }
        public virtual ICollection<TypeOfReport> TypeOfReport { get; set; }
    }
}

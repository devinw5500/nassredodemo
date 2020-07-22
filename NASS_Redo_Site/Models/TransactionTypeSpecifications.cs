using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TransactionTypeSpecifications
    {
        public int TransactionTypeSpecificationsId { get; set; }
        public string SpecType { get; set; }
        public string SpecDetails { get; set; }
        public int TransactionTypeDetailsId { get; set; }

        public virtual TransactionTypeDetails TransactionTypeDetails { get; set; }
    }
}

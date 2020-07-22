using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            TransactionTypeDetails = new HashSet<TransactionTypeDetails>();
        }

        public int TransactionTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<TransactionTypeDetails> TransactionTypeDetails { get; set; }
    }
}

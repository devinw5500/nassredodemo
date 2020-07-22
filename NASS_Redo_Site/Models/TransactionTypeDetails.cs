using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class TransactionTypeDetails
    {
        public TransactionTypeDetails()
        {
            OrderDetails = new HashSet<OrderDetails>();
            TransactionTypeSpecifications = new HashSet<TransactionTypeSpecifications>();
        }

        public int TransactionTypeDetailsId { get; set; }
        public int TransactionTypeId { get; set; }

        public virtual TransactionType TransactionType { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<TransactionTypeSpecifications> TransactionTypeSpecifications { get; set; }
    }
}

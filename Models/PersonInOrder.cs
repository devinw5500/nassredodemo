using System;
using System.Collections.Generic;

namespace TaxSystemNASS.Models
{
    public partial class PersonInOrder
    {
        public int PersonInOrder1 { get; set; }
        public int PersonId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }

        public virtual Order Order { get; set; }
        public virtual PersonalInfo Person { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace TaxSystemNASS.Models
{
    public partial class PersonInOrder
    {
        public int PersonInOrder1 { get; set; }

        [NotMapped]
        public int PersonId { get; set; }

        [NotMapped]
        public int OrderId { get; set; }

        public string Type { get; set; }

        [NotMapped]
        public virtual Order Order { get; set; }

        public virtual PersonalInfo Person { get; set; }
    }
}
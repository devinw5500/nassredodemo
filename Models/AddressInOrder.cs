namespace TaxSystemNASS.Models
{
    public partial class AddressInOrder
    {
        public int AddressInOrder1 { get; set; }
        public int AddressId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }

        public virtual Address Address { get; set; }
        public virtual Order Order { get; set; }
    }
}
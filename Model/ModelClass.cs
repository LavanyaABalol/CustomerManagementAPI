using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManagementAPI.Model
{
    public class ModelClass
    {
    }

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }

    //    public ICollection<Address> CustomerAddress{ get; set; }

    }

    public class Address
    {
       [Key]
        public int AddressId { get; set; }
        public string City{ get; set; }

        public string Street { get; set; }

        public string Mobile { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}

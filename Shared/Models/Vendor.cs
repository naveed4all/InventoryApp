using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class Vendor : BaseModelCustom
    {
        [Key]
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress { get; set; }

        public string VendorContact { get; set; }

        public string Email { get; set; }

        public string OtherDetails { get; set; }


        [InverseProperty("Vendor")]
        public ICollection<Item> VendorItems { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Item : BaseModelCustom
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal CostPrice { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal Total { get; set; }

        public int VendorId { get; set; }


        public Vendor Vendor { get; set; }

    }
}

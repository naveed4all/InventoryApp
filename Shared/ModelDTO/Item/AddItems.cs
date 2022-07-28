using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ModelDTO.Item
{
    public class AddItems
    {
        public string ItemName { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal CostPrice { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal Total { get; set; }

        public int VendorId { get; set; }
    }
}

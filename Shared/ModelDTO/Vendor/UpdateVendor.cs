using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ModelDTO.Vendor
{
    public class UpdateVendor
    {
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress { get; set; }

        public string VendorContact { get; set; }

        public string Email { get; set; }

        public string OtherDetails { get; set; }


    }
}

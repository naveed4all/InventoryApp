using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class ReturnProduct
    {
        [Key]
        public int ReturnId { get; set; }
        
        public int ItemId { get; set; }

        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } 

        public string Reason { get; set; }

        public bool IsDamaged { get; set; }

        public double ItemPrice { get; set; }

        public double Total { get; set; }

        public string Bill_Number { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class ItemStock:BaseModelCustom
    {
        [Key]
        public int StockId { get; set; }

        public string Quantity { get; set; }

        public string Status { get; set; }

        public int StockIn { get; set; }

        public int StockOut { get; set; }


    }
}

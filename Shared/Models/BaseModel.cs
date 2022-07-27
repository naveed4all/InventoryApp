namespace InventoryApp.Models
{
    public class BaseModel
    {
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
                
        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; } = true;
        //public Users ModifiedByUser { get; set; }
    }
}

namespace Shared.Models
{
    public class BaseModelCustom : BaseModel
    {
        public int AddedBy { get; set; }
        public SystemUser SystemUser { get; set; }


        public int? ModifiedBy { get; set; }
        public SystemUser? ModifiedByUser { get; set; }


    }
}

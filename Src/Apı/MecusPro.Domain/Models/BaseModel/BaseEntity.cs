namespace MecusPro.Domain.Models.BaseModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid UniqId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}

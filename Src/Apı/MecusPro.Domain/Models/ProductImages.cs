using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class ProductImages : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MediaFileId { get; set; }
        public MediaFiles MediaFiles { get; set; }
    }
}

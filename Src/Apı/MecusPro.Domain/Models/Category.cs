using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public Guid ParentUniqId { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

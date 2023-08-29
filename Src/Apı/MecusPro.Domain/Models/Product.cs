using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public string MainProductCode { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountlessPrice { get; set; }
        public string Url { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductColor>  ProductColors { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
    }
}

using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class Color : BaseEntity
    {
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public string ColorHexCode { get; set; }

        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }
}

using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class ConstantValue:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }

        public int LanguageId { get; set; }
        public Languages  Languages { get; set; }
    }
}

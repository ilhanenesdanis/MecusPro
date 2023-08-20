using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class SettingGroup : BaseEntity
    {
        public string GroupName { get; set; }

        public ICollection<SettingsKey> SettingsKeys { get; set; }
        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }
}

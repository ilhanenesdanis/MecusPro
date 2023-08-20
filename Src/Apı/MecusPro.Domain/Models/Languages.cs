using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class Languages : BaseEntity
    {
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }

        public ICollection<Color> Colors { get; set; }
        public ICollection<ConstantValue> ConstantValues { get; set; }
        public ICollection<MediaFiles> MediaFiles { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<SettingGroup> SettingGroups { get; set; }
    }
}

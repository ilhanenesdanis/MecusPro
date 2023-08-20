using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class SettingsKey : BaseEntity
    {
        public int GroupId { get; set; }
        public SettingGroup SettingGroups { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string ConvertType { get; set; }//int-string-decimal-password
        //Todo:convert Type enum olabilir
    }
}

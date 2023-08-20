using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class Media : BaseEntity
    {
        public string FolderName { get; set; }
        public string ParentFolderUniqId { get; set; }
        public int StorageType { get; set; }//Todo:enum olarak güncellenecek
    }
}

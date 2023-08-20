using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class MediaFiles : BaseEntity
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FileMineType { get; set; }
        public string FileUrl { get; set; }


        public int LanguageId { get; set; }
        public Languages languages { get; set; }
    }
}

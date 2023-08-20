using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class UserAddres : BaseEntity
    {
        public string UserId { get; set; }//Identity içerisinden gelecek
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string PostCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}

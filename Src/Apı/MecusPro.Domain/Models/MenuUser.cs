using MecusPro.Domain.Models.BaseModel;

namespace MecusPro.Domain.Models
{
    public class MenuUser:BaseEntity
    {
        public int MenuId { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public string UserId { get; set; }

    }
}

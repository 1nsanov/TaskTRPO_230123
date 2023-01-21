using Database.BaseEntity;

namespace Database.Domain
{
    public class Driver : EntityBase
    {
        public string FullName { get; set; }
        public DateTime Datebirth { get; set; }
        public string PassportCode { get; set; }


        public List<Transportation> Transportations { get; set; } = new();
    }
}

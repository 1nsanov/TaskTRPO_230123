using Database.BaseEntity;

namespace Database.Domain
{
    public class Supervisor : EntityBase
    {
        public string FullName { get; set; }
        public DateTime Datebirth { get; set; }
        public string Address { get; set; }


        public List<Transportation> Transportations { get; set; } = new();
    }
}

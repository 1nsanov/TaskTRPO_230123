using Database.BaseEntity;

namespace Database.Domain
{
    public class Ticket : EntityBase
    {
        public int Place { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string PassportCode { get; set; }
        public bool Credits { get; set; }


        public List<Transportation> Transportations { get; set; } = new();
    }
}

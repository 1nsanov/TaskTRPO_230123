using Database.BaseEntity;

namespace Database.Domain
{
    public class Bus : EntityBase
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public string NumberPlate { get; set; }
        public int PlaceCount { get; set; }


        public List<Transportation> Transportations { get; set; } = new();
    }
}

namespace Database.Dto
{
    public class BusDto : EntityDtoBase
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public string NumberPlate { get; set; }
        public int PlaceCount { get; set; }
    }
}

namespace Database.Dto
{
    public class RouteDto : EntityDtoBase
    {
        public string Number { get; set; }
        public string EndPoint { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public decimal Distant { get; set; }
        public decimal Weight { get; set; }
        public DateTime DispatchTime { get; set; }
        public DateTime ArrivalTine { get; set; }
    }
}

namespace Database.Dto
{
    public class DriverDto : EntityDtoBase
    {
        public string FullName { get; set; }
        public DateTime Datebirth { get; set; }
        public string PassportCode { get; set; }
    }
}

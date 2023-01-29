namespace Database.Dto
{
    public class TicketDto : EntityDtoBase
    {
        public int Place { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string PassportCode { get; set; }
        public bool Credits { get; set; }
    }
}

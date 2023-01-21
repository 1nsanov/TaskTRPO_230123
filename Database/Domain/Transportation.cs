using Database.BaseEntity;

namespace Database.Domain
{
    public class Transportation : EntityBase
    {
        public string Number { get; set; }
        public int RouteId { get; set; }
        public int TicketId { get; set; }
        public int SupervisorId { get; set; }
        public int BusId { get; set; }
        public int DriverId { get; set; }

        
        public Route? Route { get; set; }
        public Ticket? Ticket { get; set; }
        public Supervisor? Supervisor { get; set; }
        public Bus? Bus { get; set; }
        public Driver? Driver { get; set; }
    }
}

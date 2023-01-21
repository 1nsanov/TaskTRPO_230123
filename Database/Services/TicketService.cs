using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.BaseEntity;
using Database.Domain;

namespace Database.Services
{
    public class TicketService : BaseService<Ticket>
    {
        public TicketService(AppDbContext db) : base(db)
        {
        }

        public override Ticket? Get(int id)
        {
            var ticket = _db.Tickets.FirstOrDefault(b => b.Id == id);
            return ticket;
        }

        public override Status Create(Ticket entity)
        {
            try
            {
                _db.Tickets.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Ticket entity)
        {
            try
            {
                _db.Tickets.Update(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Remove(int id)
        {
            try
            {
                var ticket = Get(id);
                if (ticket is null) return new Status("Объект не найден.");

                _db.Tickets.Remove(ticket);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.BaseEntity;
using Database.Domain;

namespace Database.Services
{
    public class SupervisorService : BaseService<Supervisor>
    {
        public SupervisorService(AppDbContext db) : base(db)
        {
        }

        public override Supervisor? Get(int id)
        {
            var supervisor = _db.Supervisors.FirstOrDefault(b => b.Id == id);
            return supervisor;
        }

        public override Status Create(Supervisor entity)
        {
            try
            {
                _db.Supervisors.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Supervisor entity)
        {
            try
            {
                _db.Supervisors.Update(entity);
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
                var supervisor = Get(id);
                if (supervisor is null) return new Status("Объект не найден.");

                _db.Supervisors.Remove(supervisor);
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

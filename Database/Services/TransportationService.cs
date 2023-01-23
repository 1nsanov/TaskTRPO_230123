using Database.BaseEntity;
using Database.Domain;

namespace Database.Services
{
    public class TransportationService : BaseService<Transportation>
    {
        public TransportationService(AppDbContext db) : base(db)
        {
        }

        public override Transportation? Get(int id)
        {
            var transportation = _db.Transportations.FirstOrDefault(b => b.Id == id);
            return transportation;
        }

        public override Status Create(Transportation entity)
        {
            try
            {
                _db.Transportations.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Transportation entity)
        {
            try
            {
                _db.Transportations.Update(entity);
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
                var transportation = Get(id);
                if (transportation is null) return new Status("Объект не найден.");

                _db.Transportations.Remove(transportation);
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

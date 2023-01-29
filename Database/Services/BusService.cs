using Database.BaseEntity;
using Database.Domain;
using Database.Dto;

namespace Database.Services
{
    public class BusService : BaseService<Bus>
    {
        public BusService(AppDbContext db) : base(db)
        {
        }


        public override Bus? Get(int id)
        {
            var bus = _db.Buses.FirstOrDefault(b => b.Id == id);
            return bus;
        }

        public override Status Create(Bus entity)
        {
            try
            {
                _db.Buses.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Bus entity)
        {
            try
            {
                _db.Buses.Update(entity);
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
                var bus = Get(id);
                if (bus is null) return new Status("Объект не найден.");

                _db.Buses.Remove(bus);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public List<BusDto> GetList()
        {
            var buses = _db.Buses.ToList();
            var dto = buses.ConvertAll(b => new BusDto
            {
                Id = b.Id,
                Model = b.Model,
                Number = b.Number,
                NumberPlate = b.NumberPlate,
                PlaceCount = b.PlaceCount,
            });
            return dto;
        }
    }
}

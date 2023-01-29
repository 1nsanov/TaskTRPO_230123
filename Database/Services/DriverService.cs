using Database.BaseEntity;
using Database.Domain;
using Database.Dto;

namespace Database.Services
{
    public class DriverService : BaseService<Driver>
    {
        public DriverService(AppDbContext db) : base(db)
        {
        }

        public override Driver? Get(int id)
        {
            var driver = _db.Drivers.FirstOrDefault(b => b.Id == id);
            return driver;
        }

        public override Status Create(Driver entity)
        {
            try
            {
                _db.Drivers.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Driver entity)
        {
            try
            {
                _db.Drivers.Update(entity);
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
                var driver = Get(id);
                if (driver is null) return new Status("Объект не найден.");

                _db.Drivers.Remove(driver);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public List<DriverDto> GetList()
        {
            var drivers = _db.Drivers.ToList();
            var dto = drivers.ConvertAll(d => new DriverDto
            {
                Id = d.Id,
                Datebirth = d.Datebirth,
                FullName = d.FullName,
                PassportCode = d.PassportCode
            });
            return dto;
        }
    }
}

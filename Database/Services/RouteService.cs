using Database.BaseEntity;
using Database.Domain;
using Database.Dto;

namespace Database.Services
{
    public class RouteService : BaseService<Route>
    {
        public RouteService(AppDbContext db) : base(db)
        {
        }

        public override Route? Get(int id)
        {
            var route = _db.Routes.FirstOrDefault(b => b.Id == id);
            return route;
        }

        public override Status Create(Route entity)
        {
            try
            {
                _db.Routes.Add(entity);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public override Status Update(Route entity)
        {
            try
            {
                _db.Routes.Update(entity);
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
                var route = Get(id);
                if (route is null) return new Status("Объект не найден.");

                _db.Routes.Remove(route);
                _db.SaveChanges();
                return new Status();
            }
            catch (Exception e)
            {
                return new Status(e.Message);
            }
        }

        public List<RouteDto> GetList()
        {
            var routes = _db.Routes.ToList();
            var dto = routes.ConvertAll(r => new RouteDto
            {
                 Id = r.Id,
                 Area = r.Area,
                 ArrivalTine = r.ArrivalTine,
                 DispatchTime = r.DispatchTime,
                 Distant = r.Distant,
                 EndPoint = r.EndPoint,
                 Number = r.Number,
                 Region = r.Region,
                 Weight = r.Weight
            });
            return dto;
        }
    }
}

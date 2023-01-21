namespace Database.BaseEntity
{
    public abstract class BaseService<T>
    {
        protected AppDbContext _db { get; }

        protected BaseService(AppDbContext db)
        {
            _db = db;
        }

        public abstract T? Get(int id);
        public abstract Status Create(T entity);
        public abstract Status Update(T entity);
        public abstract Status Remove(int id);
    }
}

using Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AppDbContext : DbContext
    {

        #region Tables

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Transportation> Transportations { get; set; }

        #endregion

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = postgres;Password=root;Server=localhost;Port=5432;Database=BusStation;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var routes = modelBuilder.Entity<Route>();
            var buses = modelBuilder.Entity<Bus>();
            var drivers = modelBuilder.Entity<Driver>();
            var supervisor = modelBuilder.Entity<Supervisor>();
            var ticket = modelBuilder.Entity<Ticket>();

            routes.HasMany(x => x.Transportations).WithOne(x => x.Route);
            buses.HasMany(x => x.Transportations).WithOne(x => x.Bus);
            drivers.HasMany(x => x.Transportations).WithOne(x => x.Driver);
            supervisor.HasMany(x => x.Transportations).WithOne(x => x.Supervisor);
            ticket.HasMany(x => x.Transportations).WithOne(x => x.Ticket);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace EventProjectWeb.Model.ORM
{
    public class EventProjectContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2KEA18U\\SQLEXPRESS;Database = AkademiEvent;Trusted_Connection = True;trustservercertificate=true");
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Vanue> Vanues { get; set; }


    }
}

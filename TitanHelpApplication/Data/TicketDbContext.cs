using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Models;

namespace TitanHelpApplication.Data
{
    public class TicketDbContext : DbContext
    {
        // Constructor: Removed the ; and added { }
        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {
        }

        // This creates the "Tickets" table in your database
        // We call the property 'Tickets' (plural) to keep it clean
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This ensures the table name is exactly "Tickets" inside SQLite
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
        }
    }
}
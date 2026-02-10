using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Models;

namespace TitanHelpApplication.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Name = "Alice Smith",
                    ProblemDescription = "Printer jammed",
                    Priority = "Medium",
                    Status = "Open",
                    // FIXED: Use a specific static date instead of DateTime.Now
                    Date = new DateTime(2026, 2, 6)
                },
                new Ticket
                {
                    Id = 2,
                    Name = "Bob Jones",
                    ProblemDescription = "Email login failed",
                    Priority = "High",
                    Status = "Open",
                    // FIXED: Use a specific static date instead of DateTime.Now
                    Date = new DateTime(2026, 2, 6)
                }
            );
        }
    }
}
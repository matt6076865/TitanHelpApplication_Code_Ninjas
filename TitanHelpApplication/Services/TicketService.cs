using TitanHelpApplication.Models;
using TitanHelpApplication.Data;
using System.Linq;

namespace TitanHelpApplication.Services
{
    public class TicketService : ITicketService
    {
        private readonly TicketDbContext _context;

        public TicketService(TicketDbContext context)
        {
            _context = context;
        }

        // ERROR FIX: Use { } brackets, NOT a semicolon ;
        public IEnumerable<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }
    }
}
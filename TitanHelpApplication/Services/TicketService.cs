using TitanHelpApplication.Models;
using TitanHelpApplication.Data;
using Microsoft.EntityFrameworkCore; // Needed for ToListAsync
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TitanHelpApplication.Services
{
    public class TicketService : ITicketService
    {
        private readonly TicketDbContext _context;

        public TicketService(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
        {
            // Await the database call so the server thread is free to do other things
            return await _context.Tickets.ToListAsync();
        }

        public async Task AddTicketAsync(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Data;
using TitanHelpApplication.Models;

namespace TitanHelpApplication.Repositories
{
    public class TicketRepository : ITicketRepository //The Implementation of Ticket Repository
    {
        private readonly TicketDbContext _context;

        public TicketRepository(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            return await _context.Ticket.ToListAsync();
        }

        public async Task<Ticket?> GetTicketByIdAsync(int id)
        {
            return await _context.Ticket.FindAsync(id);
        }

        public async Task AddTicketAsync(Ticket ticket)
        {
            await _context.Ticket.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
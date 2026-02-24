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

        // The method returns a nullable Ticket (Ticket?) because the ticket with the specified ID might not exist
        public async Task<Ticket?> GetTicketByIdAsync(int id)
        {
            // Finds a specific ticket by its primary key
            return await _context.Tickets.FindAsync(id);
        }

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTicketAsync(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }
    }
}
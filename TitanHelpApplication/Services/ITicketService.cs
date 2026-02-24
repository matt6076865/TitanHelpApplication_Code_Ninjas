using System.Collections.Generic;
using System.Threading.Tasks;
using TitanHelpApplication.Models;

namespace TitanHelpApplication.Services
{
    public interface ITicketService
    {
        // Wrapping the return types in Task<> makes them asynchronous
        Task<IEnumerable<Ticket>> GetAllTicketsAsync();
        Task AddTicketAsync(Ticket ticket);

        // This method returns a nullable Ticket (Ticket?) because the ticket with the specified ID might not exist
        Task<Ticket?> GetTicketByIdAsync(int id);
        Task UpdateTicketAsync(Ticket ticket);
        Task DeleteTicketAsync(int id);
    }
}
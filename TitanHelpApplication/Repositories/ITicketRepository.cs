using TitanHelpApplication.Models;

namespace TitanHelpApplication.Repositories
{
    public interface ITicketRepository //The Interface for Ticket Repository
    {
        Task<List<Ticket>> GetAllTicketsAsync();
        Task<Ticket?> GetTicketByIdAsync(int id);
        Task AddTicketAsync(Ticket ticket);
        Task SaveChangesAsync();
    }
}
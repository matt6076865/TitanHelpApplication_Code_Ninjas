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
    }
}
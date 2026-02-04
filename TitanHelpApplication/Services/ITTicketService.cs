using TitanHelpApplication.Models;

namespace TitanHelpApplication.Services

{
    public interface ITicketService
    {
        IEnumerable<Models.Ticket> GetAllTickets();
        void AddTicket(Models.Ticket ticket);
    }
}
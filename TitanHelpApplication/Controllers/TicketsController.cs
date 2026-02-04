using Microsoft.AspNetCore.Mvc;
using TitanHelpApplication.Models;
using TitanHelpApplication.Services;

namespace TitanHelpApplication.Controllers 
{
    public class TicketsController : Controller
    {
        // Change from Context to Service
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: Tickets
        public IActionResult Index()
        {
            // Uses the service logic (which includes the sorting we wrote)
            var tickets = _ticketService.GetAllTickets();
            return View(tickets);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,ProblemDescription,Priority")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                // Uses the service logic (which sets the Date and "Open" status automatically)
                _ticketService.AddTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }
    }
}
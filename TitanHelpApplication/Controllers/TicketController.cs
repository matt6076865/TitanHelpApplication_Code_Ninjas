using Microsoft.AspNetCore.Mvc;
using TitanHelpApplication.Models;
using TitanHelpApplication.Services;

namespace TitanHelpApplication.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: Ticket/Index
        public IActionResult Index()
        {
            var tickets = _ticketService.GetAllTickets();
            return View(tickets);
        }

        // GET: Ticket/Create
        public IActionResult Create()
        {
            // Optional: Set a default date for the new ticket
            var newTicket = new Ticket { Date = DateTime.Now };
            return View(newTicket);
        }

        // POST: Ticket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Updated [Bind] to match your database columns: Name, Date, ProblemDescription, Status, Priority
        public IActionResult Create([Bind("Id,Name,Date,ProblemDescription,Status,Priority")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _ticketService.AddTicket(ticket);
                return RedirectToAction(nameof(Index));
            }

            // If we got this far, something failed, redisplay form
            return View(ticket);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TitanHelpApplication.Models;
using TitanHelpApplication.Services;

namespace TitanHelpApplication.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        // Dependency Injection: Bringing in the Business Logic layer
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
            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _ticketService.AddTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            // If validation fails, return to the form with errors
            return View(ticket);
        }
    }
}
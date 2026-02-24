using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TitanHelpApplication.Models;
using TitanHelpApplication.Services;

namespace TitanHelpApplication.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            // Await the data from the database, then pass it to the View
            var tickets = await _ticketService.GetAllTicketsAsync();
            return View(tickets);
        }

        // GET: Tickets/Create
        // This just displays the blank form. No async or database calls needed here.
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketCreateDTO ticketDto) // Uses DTO
        {
            if (ModelState.IsValid)
            {
                // Map the DTO to your actual database entity
                var newTicket = new Ticket
                {
                    Name = ticketDto.Name,
                    ProblemDescription = ticketDto.ProblemDescription,
                    Priority = ticketDto.Priority,
                    Date = DateTime.Now,
                    Status = "Open"
                };

                // Await the asynchronous Add method
                await _ticketService.AddTicketAsync(newTicket);

                return RedirectToAction(nameof(Index));
            }

            // If validation fails, return the form with the user's data so they can fix it
            return View(ticketDto);
        }
    }
}
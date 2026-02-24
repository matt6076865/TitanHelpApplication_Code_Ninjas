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

        // --- 1. INDEX (READ ALL) ---
        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();
            return View(tickets);
        }

        // --- 2. CREATE ---
        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketCreateDTO ticketDto)
        {
            if (ModelState.IsValid)
            {
                var newTicket = new Ticket
                {
                    Name = ticketDto.Name,
                    ProblemDescription = ticketDto.ProblemDescription,
                    Priority = ticketDto.Priority,
                    Date = DateTime.Now,
                    Status = "Open"
                };

                await _ticketService.AddTicketAsync(newTicket);
                return RedirectToAction(nameof(Index));
            }
            return View(ticketDto);
        }

        // --- 3. DETAILS (READ ONE) ---
        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null) return NotFound();

            return View(ticket);
        }

        // --- 4. EDIT (UPDATE) ---
        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null) return NotFound();

            return View(ticket);
        }

        // POST: Tickets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Ticket ticket)
        {
            if (id != ticket.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _ticketService.UpdateTicketAsync(ticket);
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }

        // --- 5. DELETE ---
        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null) return NotFound();

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _ticketService.DeleteTicketAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
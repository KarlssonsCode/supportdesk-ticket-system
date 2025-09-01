using Microsoft.AspNetCore.Mvc;
using SupportDesk.Shared.Models;

namespace SupportDesk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private static int _nextId = 4;

        [HttpGet]
        public ActionResult<List<Ticket>> GetTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Computer won't start",
                    Description = "My computer just shows a black screen when I turn it on",
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new Ticket
                {
                    Id = 2,
                    Title = "Email not working",
                    Description = "Can't send emails, getting error message",
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new Ticket
                {
                    Id = 3,
                    Title = "Printer offline",
                    Description = "Office printer shows as offline for everyone",
                    CreatedAt = DateTime.UtcNow.AddHours(-3)
                }
            };

            return Ok(tickets);


        }

        [HttpPost]
        public async Task<ActionResult<Ticket>> CreateTicket(Ticket ticket)
        {
            ticket.Id = _nextId++;
            ticket.CreatedAt = DateTime.UtcNow;
            return Ok(ticket);
        }
    }
}

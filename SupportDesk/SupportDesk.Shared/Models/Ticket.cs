using System.ComponentModel.DataAnnotations;

namespace SupportDesk.Shared.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

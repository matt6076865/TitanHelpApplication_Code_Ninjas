using System.ComponentModel.DataAnnotations;
using TitanHelpApplication.Models; // For the TicketPriority enum

namespace TitanHelpApplication.Models
{
    public class TicketCreateDTO
    {
        [Required(ErrorMessage = "Requester name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Problem description is required")]
        [StringLength(1000)]
        [Display(Name = "Problem Description")]
        public string ProblemDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a priority level")]
        public TicketPriority Priority { get; set; }
    }
}
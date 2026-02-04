using System;
using System.ComponentModel.DataAnnotations;

namespace TitanHelpApplication.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requester name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Date Created")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Problem description is required")]
        [StringLength(1000)]
        [Display(Name = "Problem Description")]
        public string ProblemDescription { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = "Open";

        [Required(ErrorMessage = "Please select a priority level")]
        public TicketPriority Priority { get; set; }
    }

    public enum TicketPriority
    {
        Low,
        Medium,
        High
    }
}



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
        public required string Name { get; set; } // Fixed with 'required'

        [Required]
        [Display(Name = "Date Created")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Problem description is required")]
        [StringLength(1000)]
        [Display(Name = "Problem Description")]
        public required string ProblemDescription { get; set; } // Fixed with 'required'

        [Required]
        public string Status { get; set; } = "Open"; // No error here because we gave it a default value ("Open")

        [Required]
        public TicketPriority Priority { get; set; }
    }

    public enum TicketPriority
    {
        Low,
        Medium,
        High
    }
}





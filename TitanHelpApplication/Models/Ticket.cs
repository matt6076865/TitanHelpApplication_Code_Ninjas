using System.ComponentModel.DataAnnotations;

namespace TitanHelpApplication.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        // Changed back to 'Name' to match your error
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        // Changed back to 'Date'
        public DateTime Date { get; set; } = DateTime.Now;

        // Changed back to 'ProblemDescription'
        [Required(ErrorMessage = "Problem Description is required.")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string ProblemDescription { get; set; }

        [Required]
        public string Status { get; set; } = "Open";

        [Required]
        public string Priority { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Mission6_Stuart.Models
{
    public class Collection
    {
        [Key]
        public int MovieID { get; set; }

        [Required] // Title is required
        public string Title { get; set; }

        [Required] // Category is required
        public string Category { get; set; }

        [Required] // Year is required
        public int Year { get; set; }

        [Required] // Director is required
        public string Director { get; set; }

        [Required] // Rating is required
        public string Rating { get; set; }

        public string? Lent { get; set; } // Lent is optional

        public bool Edited { get; set; } // Edited is optional

        [MaxLength(25)] // Notes should be limited to 25 characters
        public string? Notes { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        public string? Country { get; set; }

        public IList<Author>? authors { get; set; }
    }
}

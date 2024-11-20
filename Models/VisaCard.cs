using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.Models
{
    public class VisaCard
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Number { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}

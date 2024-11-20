using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Title is required")]
        public string? Title { get; set; }
        public DateTime? PublishedDate { get; set; }
        public ICollection<Author>? Authors { get; set; }
        public ICollection<Genre>? Genres { get; set; }
    }
}

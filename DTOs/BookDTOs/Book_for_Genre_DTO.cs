using lets_eat_book_library.DTOs.AuthorDTOs;
using lets_eat_book_library.DTOs.GenreDTOs;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.BookDTOs
{
    public class Book_for_Genre_DTO
    {
        [Required(ErrorMessage = "The Title is required")]
        public string? Title { get; set; }
        public DateTime? PublishedDate { get; set; }
        public ICollection<Author_add_and_update_DTO>? Authors { get; set; }
    }
}

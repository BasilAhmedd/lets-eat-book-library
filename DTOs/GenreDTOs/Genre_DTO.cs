using lets_eat_book_library.DTOs.BookDTOs;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.GenreDTOs
{
    public class Genre_DTO
    {
        [Required]
        public string? Name { get; set; }
        public ICollection<Book_for_Genre_DTO>? Books { get; set; }
    }
}

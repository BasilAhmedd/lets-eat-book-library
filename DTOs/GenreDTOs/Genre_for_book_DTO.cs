using lets_eat_book_library.DTOs.BookDTOs;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.GenreDTOs
{
    public class Genre_for_book_DTO
    {
        [Required]
        public string? Name { get; set; }
    }
}

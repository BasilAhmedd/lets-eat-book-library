using lets_eat_book_library.DTOs.AuthorDTOs;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.NationalityDTOs
{
    public class Nationality_DTO
    {
        [Required]
        public string? Country { get; set; }

        public ICollection<Author_for_Nationality_DTO>? authors { get; set; }
    }
}

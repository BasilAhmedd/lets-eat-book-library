using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.NationalityDTOs
{
    public class Nationality_for_author_DTO
    {
        [Required]
        public string? Country { get; set; }
    }
}

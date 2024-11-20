using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.VisaCardDTos
{
    public class VisaCard_for_author_DTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Number { get; set; }

    }
}

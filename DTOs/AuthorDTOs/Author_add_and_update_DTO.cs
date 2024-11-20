using lets_eat_book_library.DTOs.NationalityDTOs;
using lets_eat_book_library.DTOs.VisaCardDTos;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.AuthorDTOs
{
    public class Author_add_and_update_DTO
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }

        public Nationality_for_author_DTO? Nationality { get; set; }

        public VisaCard_for_author_DTO? VisaCard { get; set; }
    }
}

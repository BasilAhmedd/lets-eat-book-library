using lets_eat_book_library.DTOs.NationalityDTOs;
using lets_eat_book_library.DTOs.VisaCardDTos;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.AuthorDTOs
{
    public class Author_for_Nationality_DTO
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }

        public VisaCard_for_author_DTO? VisaCard { get; set; }
    }
}

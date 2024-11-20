using lets_eat_book_library.DTOs.BookDTOs;
using lets_eat_book_library.DTOs.NationalityDTOs;
using lets_eat_book_library.DTOs.VisaCardDTos;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.AuthorDTOs
{
    public class Author_Get_DTO
    {
        public string Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public Nationality_for_author_DTO? Nationality { get; set; }

        public VisaCard_for_author_DTO? VisaCard { get; set; }
        public ICollection<Book_for_author_DTO>? Books { get; set; }
    }
}

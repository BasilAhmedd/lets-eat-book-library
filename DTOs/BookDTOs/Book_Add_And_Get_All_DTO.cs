using lets_eat_book_library.DTOs.AuthorDTOs;
using lets_eat_book_library.DTOs.GenreDTOs;
using lets_eat_book_library.Models;
using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.DTOs.BookDTOs
{
    public class Book_Add_And_Get_All_DTO
    {
        [Required(ErrorMessage = "The Title is required")]
        public string? Title { get; set; }
        public DateTime? PublishedDate { get; set; }
        public ICollection<Author_add_and_update_DTO>? Authors { get; set; }
        public ICollection<Genre_for_book_DTO>? Genres { get; set; }
    }
}

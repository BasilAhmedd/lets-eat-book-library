using System.ComponentModel.DataAnnotations;

namespace lets_eat_book_library.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }

        public int NationalityId { get; set; }
        public Nationality? Nationality { get; set; }

        public VisaCard? VisaCard { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}

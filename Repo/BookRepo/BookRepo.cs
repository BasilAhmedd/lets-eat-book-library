using lets_eat_book_library.Data;
using lets_eat_book_library.DTOs.AuthorDTOs;
using lets_eat_book_library.DTOs.BookDTOs;
using lets_eat_book_library.DTOs.GenreDTOs;
using lets_eat_book_library.DTOs.NationalityDTOs;
using lets_eat_book_library.DTOs.VisaCardDTos;
using lets_eat_book_library.Models;
using Microsoft.EntityFrameworkCore;
namespace lets_eat_book_library.Repo.BookRepo
{
    public class BookRepo : IBookRepo
    {
        private readonly AppDbContext _context;
        public BookRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddAll(Book_Add_And_Get_All_DTO dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                PublishedDate = dto.PublishedDate,
                Genres = dto.Genres.Select(s=>new Genre
                {
                    Name= s.Name,
                }).ToList(),
                Authors = dto.Authors.Select(x => new Author
                {
                    Name = x.Name,
                    EmailAddress = x.EmailAddress,
                    Phone = x.Phone,
                    Nationality = new Nationality
                    {
                        Country = x.Nationality.Country
                    },
                    VisaCard = new VisaCard
                    {
                        Name = x.VisaCard.Name,
                        Number = x.VisaCard.Number,
                    }
                }
              

                ).ToList(),
            };

            _context.books.Add(book);
            _context.SaveChanges();
        }

        public void AddById(Book_Add_All_By_ID_DTO dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                PublishedDate = dto.PublishedDate,
                Authors = _context.authors.Where(x => dto.AuthorsId.Contains(x.Id)).ToList(),
                Genres=_context.genres.Where(x=>dto.GenresId.Contains(x.Id)).ToList()
            };
            _context.books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.books.FirstOrDefault(x => x.Id == id);
            _context.books.Remove(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book_Add_And_Get_All_DTO> GetAll()
        {
            var book = _context.books.
                Include(x => x.Genres).
                Include(x => x.Authors).
                ThenInclude(x=>x.Nationality)
                .Include(x=>x.Authors).
                ThenInclude(x=>x.VisaCard)
                .ToList();

            return book.Select(x => new Book_Add_And_Get_All_DTO
            {
                PublishedDate = x.PublishedDate,
                Title = x.Title,
                Authors = x.Authors.Select(s => new Author_add_and_update_DTO
                {
                    Name = s.Name,
                    EmailAddress = s.EmailAddress,
                    Phone = s.Phone,
                    Nationality = new Nationality_for_author_DTO
                    {
                        Country = s.Nationality.Country
                    },
                    VisaCard = new VisaCard_for_author_DTO
                    {
                        Name = s.VisaCard.Name,
                        Number = s.VisaCard.Number
                    }

                }).ToList(),
                Genres = x.Genres.Select(x => new Genre_for_book_DTO
                {
                    Name = x.Name
                }).ToList()
            });
        }

        public Book_Add_And_Get_All_DTO GetById(int id)
        {
            var book = _context.books.Include(x=>x.Genres).
                Include(x=>x.Authors).ThenInclude(x=>x.Nationality).Include(x=>x.Authors)
                .ThenInclude(x=>x.VisaCard).FirstOrDefault(x=>x.Id==id);

            return new Book_Add_And_Get_All_DTO
            {
                PublishedDate = book.PublishedDate,
                Title = book.Title,
                Genres = book.Genres.Select(x => new Genre_for_book_DTO
                {
                    Name = x.Name

                }).ToList(),
                Authors = book.Authors.Select(x=> new Author_add_and_update_DTO
                {
                    Name=x.Name,
                    EmailAddress = x.EmailAddress,
                    Phone = x.Phone,
                    Nationality = new Nationality_for_author_DTO
                    {
                        Country = x.Nationality.Country
                    },
                    VisaCard = new VisaCard_for_author_DTO
                    {
                        Name = x.VisaCard.Name,
                        Number = x.VisaCard.Number,
                    }



                }).ToList(),
                
            };
       }

        public void UpdateAll(Book_Add_And_Get_All_DTO dto, int id)
        {
            var book = _context.books.Include(x => x.Genres)
                .Include(x => x.Authors).
                ThenInclude(x => x.Nationality).Include(x => x.Authors)
                .ThenInclude(x => x.VisaCard).FirstOrDefault(x => x.Id == id);
            book.Title = dto.Title;
            book.PublishedDate = dto.PublishedDate;
            book.Authors = dto.Authors.Select(x => new Author
            {
                EmailAddress = x.EmailAddress,
                Name = x.Name,
                Phone = x.Phone,
                Nationality = new Nationality { Country = x.Nationality.Country },
                VisaCard = new VisaCard 
                { Name = x.VisaCard.Name,
                    Number = x.VisaCard.Number 
                }
            }).ToList();
            book.Genres = dto.Genres.Select(x => new Genre
            {
                Name = x.Name,
            }).ToList();

            _context.books.Update(book);
            _context.SaveChanges();
        }

        public void UpdateById(Book_Add_All_By_ID_DTO dto, int id)
        {
            throw new NotImplementedException();
        }
    }
}

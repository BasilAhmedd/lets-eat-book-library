using lets_eat_book_library.Models;
using Microsoft.EntityFrameworkCore;

namespace lets_eat_book_library.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<VisaCard> visaCards { get; set; }
        public DbSet<Nationality> nationalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(x=>x.Authors).WithMany(x=>x.Books);
            modelBuilder.Entity<Book>().HasMany(x=>x.Genres).WithMany(x=>x.Books);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using GuideNeonEF.Models;

namespace GuideNeonEF
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var authors = new[]
            {
                new Author { Id = 1, Name = "J.R.R. Tolkien", Bio = "The creator of Middle-earth and author of The Lord of the Rings.", Country = "United Kingdom"},
                new Author { Id = 2, Name = "George R.R. Martin", Bio = "The author of the epic fantasy series A Song of Ice and Fire.", Country = "United States"},
                new Author { Id = 3, Name = "J.K. Rowling", Bio = "The creator of the Harry Potter series.", Country = "United Kingdom"}
            };
            modelBuilder.Entity<Author>().HasData(authors);            

            var books = new[]
            {
                new Book { Id = 1, Title = "The Fellowship of the Ring", AuthorId = 1 },
                new Book { Id = 2, Title = "The Two Towers", AuthorId = 1 },
                new Book { Id = 3, Title = "The Return of the King", AuthorId = 1 },
                new Book { Id = 4, Title = "A Game of Thrones", AuthorId = 2 },
                new Book { Id = 5, Title = "A Clash of Kings", AuthorId = 2 },
                new Book { Id = 6, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 3 },
                new Book { Id = 7, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 3 }
            };
            modelBuilder.Entity<Book>().HasData(books);
        }
    }
}
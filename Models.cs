using System;
using Microsoft.EntityFrameworkCore;

namespace GuideNeonEF.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Country { get; set; }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public DateTime CreatedAt { get; set; }
    }   
}
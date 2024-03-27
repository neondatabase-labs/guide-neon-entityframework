using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using GuideNeonEF;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

app.UseRouting();
app.MapGet("/authors", async (ApplicationDbContext db) =>
    await db.Authors.ToListAsync());
app.MapGet("/books/{authorId}", async (int authorId, ApplicationDbContext db) =>
    await db.Books.Where(b => b.AuthorId == authorId).ToListAsync());

app.Run();
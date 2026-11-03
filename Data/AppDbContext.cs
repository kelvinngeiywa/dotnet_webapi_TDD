using Microsoft.EntityFrameworkCore;
using rest_tdd.Models;

namespace rest_tdd.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                            new Book
                            {
                                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                                Title = "Things Fall Apart",
                                Author = "Chinua Achebe"
                            },
            new Book
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Title = "The River Between",
                Author = "Ngugi wa Thiong'o"
            },
                        new Book
                        {
                            Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                            Title = "Weep Not, Child",
                            Author = "Ngugi wa Thiong'o"
                        },
            new Book
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Title = "Animal Farm",
                Author = "George Orwell"
            },
                        new Book
                        {
                            Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                            Title = "1984",
                            Author = "George Orwell"
                        },
            new Book
            {
                Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald"
            },
            new Book
            {
                Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                Title = "Pride and Prejudice",
                Author = "Jane Austen"
            },
            new Book
            {
                Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee"
            },
            new Book
            {
                Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                Title = "The Alchemist",
                Author = "Paulo Coelho"
            },
            new Book
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Title = "Atomic Habits",
                Author = "James Clear"
            }

                );
        }
        public DbSet<Book> books { get; set; }
    }
}

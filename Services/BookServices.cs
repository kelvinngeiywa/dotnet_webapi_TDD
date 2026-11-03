using Microsoft.EntityFrameworkCore;
using rest_tdd.Data;
using rest_tdd.Models;
using rest_tdd.Models.DTOs;
using rest_tdd.Services.Iservices;

namespace rest_tdd.Services
{
    public class BookServices(AppDbContext dbContext) : IBook
    {
        public async Task<Book> AddNewBook(AddBookDTO addBookDTO)
        {
            var newBook = new Book { 
                Id=Guid.NewGuid(),
                Title=addBookDTO.Title,
                Author=addBookDTO.Author
            };

            dbContext.books.Add(newBook);
            await dbContext.SaveChangesAsync();
            return newBook;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await dbContext.books.ToListAsync();
        }
    }
}

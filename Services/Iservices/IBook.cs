using rest_tdd.Models;
using rest_tdd.Models.DTOs;

namespace rest_tdd.Services.Iservices
{
    public interface IBook
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> AddNewBook(AddBookDTO addBookDTO);

    }
}

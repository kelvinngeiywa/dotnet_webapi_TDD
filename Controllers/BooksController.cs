using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rest_tdd.Models;
using rest_tdd.Models.DTOs;
using rest_tdd.Services.Iservices;

namespace rest_tdd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(IBook bookServices) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks(){
            var books = await bookServices.GetAllBooks();

            if(books is null || !books.Any())
            {
                return NotFound();
            }
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(AddBookDTO bookDTO)
        {
            var newBook = await bookServices.AddNewBook(bookDTO);
            return Ok(newBook);
        }
    }
}

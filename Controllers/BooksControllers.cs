using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models;
using my_books.Data.Models.ViewModels;
using my_books.Data.Services;
using System.Collections.Generic;

namespace my_books.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksControllers : Controller
    {

        public BooksService _bookService;

        public BooksControllers(BooksService booksService)
        {
            _bookService = booksService;
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GettAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetAllBooks(int id)
        {
            var Book = _bookService.GetBookById(id);
            return Ok(Book);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            var updateBook = _bookService.UpdateBookById(id, book);
            return Ok(updateBook);
        }

        [HttpDelete("delete-book-by-id{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _bookService.DeleteBookById(id);
            return Ok();
        }
    }
}

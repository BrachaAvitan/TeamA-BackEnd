using App.Api.Mappers;
using App.Api.Models;
using App.BL.Interfaces;
using App.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;
        public BooksController(IBookService booksService)
        {
            _bookService = booksService;
        }
        [HttpGet]
        public async Task<List<BookDTO>> GetAllBooks()
        {
            try
            {
                return await _bookService.GetAllBooks();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<Guid> CreateBook([FromBody] BookRequest book)
        {
            try
            {
                return await _bookService.CreateBook(BookMapper.Map(book));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public async Task<Guid> UpdateBook(Guid id, [FromBody] BookRequest book)
        {
            try
            {
                return await _bookService.UpdateBook(id, BookMapper.Map(book));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<List<BookDTO>> DeleteBook(Guid id)
        {
            try
            {
                return await _bookService.DeleteBook(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

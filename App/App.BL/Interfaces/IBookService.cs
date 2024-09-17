using App.BL.Mappers;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Interfaces
{
    public interface IBookService
    {
        public Task<List<BookDTO>> GetAllBooks();
        public Task<Guid> CreateBook(BookDTO book);
        public Task<Guid> UpdateBook(Guid id, BookDTO book);
        public Task<List<BookDTO>> DeleteBook(Guid id);
    }
}

using App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Interfaces
{
    public interface IBooksRepository
    {
        public Task<List<Book>> GetAllBooks();
        public Task<Guid> CreateBook(Book book);
        public Task<Guid> UpdateBook(Guid id, Book book);
        public Task<List<Book>> DeleteBook(Guid id);
    }
}

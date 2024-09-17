using App.BL.Interfaces;
using App.BL.Mappers;
using App.DAL.Entities;
using App.DAL.Interfaces;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace App.BL.Services
{
    public class BookService : IBookService
    {
        public IBooksRepository books;

        public BookService (IBooksRepository booksRepository)
        {
            books = booksRepository;
        }

        public async Task<List<BookDTO>> GetAllBooks()
        {
            try
            {
                List<Book> booksList = await books.GetAllBooks();
                return booksList.Select(u => BookMapper.Map(u)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> CreateBook(BookDTO book)
        {
            try
            {
                return await books.CreateBook(BookMapper.Map(book));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> UpdateBook(Guid id, BookDTO book)
        {
            try
            {
                return await books.UpdateBook(id, BookMapper.Map(book));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<BookDTO>> DeleteBook(Guid id)
        {
            try
            {
                var newBookList = await books.DeleteBook(id);
                var bookDTOList = newBookList.Select(u => BookMapper.Map(u)).ToList();
                return bookDTOList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

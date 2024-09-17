using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        public BooksContext dbContext;

        public BooksRepository(BooksContext booksContext)
        {
            dbContext = booksContext;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            try
            {
                return await dbContext.Books.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> CreateBook(Book book)
        {
            try
            {
                await dbContext.Books.AddAsync(book);
                await dbContext.SaveChangesAsync();
                return (Guid)book.IdBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> UpdateBook(Guid id, Book book)
        {
            try
            {
                Book bookToUpdate = await dbContext.Books.SingleOrDefaultAsync(u => u.IdBook == id);
                bookToUpdate.BookName = book.BookName;
                bookToUpdate.AuthorName = book.AuthorName;
                bookToUpdate.Price = book.Price;
                bookToUpdate.TargetAudience = book.TargetAudience;
                bookToUpdate.YearOfIssue = book.YearOfIssue;
                return book.IdBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Book>> DeleteBook(Guid id)
        {
            try
            {
                var book = await dbContext.Books.SingleOrDefaultAsync(u => u.IdBook == id);
                dbContext.Books.Remove(book);
                await dbContext.SaveChangesAsync();
                return await dbContext.Books.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using App.DAL.Entities;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Mappers
{
    internal static class BookMapper
    {
        internal static Book Map(BookDTO book)
        {
            return new Book
            {
                IdBook = book.IdBook,
                BookName = book.BookName,
                AuthorName = book.AuthorName,
                Price = book.Price,
                TargetAudience = book.TargetAudience,
                YearOfIssue = book.YearOfIssue,
            };
        }
        internal static BookDTO Map(Book book)
        {
            return new BookDTO
            {
                IdBook = book.IdBook,
                BookName = book.BookName,
                AuthorName = book.AuthorName,
                Price = book.Price,
                TargetAudience = book.TargetAudience,
                YearOfIssue = book.YearOfIssue,
            };
        }
    }
}

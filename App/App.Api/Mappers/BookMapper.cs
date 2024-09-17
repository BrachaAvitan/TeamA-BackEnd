using App.Api.Models;
using App.DTO.Models;

namespace App.Api.Mappers
{
    internal static class BookMapper
    {
        internal static BookDTO Map(BookRequest bookRequest)
        {
            return new BookDTO
            {
                IdBook = Guid.NewGuid(),
                BookName = bookRequest.BookName,
                AuthorName = bookRequest.AuthorName,
                Price = bookRequest.Price,
                TargetAudience = bookRequest.TargetAudience,
                YearOfIssue = bookRequest.YearOfIssue,
            };
        }
    }
}

namespace App.Api.Models
{
    public class BookRequest
    {
        public string? BookName { get; set; }

        public string? AuthorName { get; set; }

        public decimal? Price { get; set; }

        public string? TargetAudience { get; set; }

        public DateOnly? YearOfIssue { get; set; }
    }
}

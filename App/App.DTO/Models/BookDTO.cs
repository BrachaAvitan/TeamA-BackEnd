using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO.Models
{
    public class BookDTO
    {
        public Guid IdBook { get; set; }

        public string? BookName { get; set; }

        public string? AuthorName { get; set; }

        public decimal? Price { get; set; }

        public string? TargetAudience { get; set; }

        public DateOnly? YearOfIssue { get; set; }
    }
}

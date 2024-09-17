using System;
using System.Collections.Generic;

namespace App.DAL.Entities;

public partial class Book
{
    public Guid IdBook { get; set; }

    public string? BookName { get; set; }

    public string? AuthorName { get; set; }

    public decimal? Price { get; set; }

    public string? TargetAudience { get; set; }

    public DateOnly? YearOfIssue { get; set; }
}

using System;
using System.Collections.Generic;
using App.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.DataContext;

public partial class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.IdBook).HasName("PK__Books__2756CBDB7D89EEBF");

            entity.Property(e => e.AuthorName).HasMaxLength(255);
            entity.Property(e => e.BookName).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TargetAudience).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

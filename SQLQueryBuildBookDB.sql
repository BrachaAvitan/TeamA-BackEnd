-- יצירת מסד נתונים חדש בשם "books"
CREATE DATABASE books;
GO

-- שימוש במסד הנתונים שיצרנו
USE books;
GO

-- יצירת הטבלה "Books"

CREATE TABLE [dbo].[Books](
	[IdBook] [uniqueidentifier] NOT NULL,
	[BookName] [nvarchar](255) NULL,
	[AuthorName] [nvarchar](255) NULL,
	[Price] [decimal](10, 2) NULL,
	[TargetAudience] [nvarchar](50) NULL,
	[YearOfIssue] [date] NULL,
CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([IdBook])
);
GO
-- הוספת שישה ספרים שונים לטבלה
INSERT INTO [dbo].[Books] (IdBook, BookName, AuthorName, Price, TargetAudience, YearOfIssue) VALUES
(NEWID(), 'The Hobbit', 'J.R.R. Tolkien', 12.99, 'Young Adults', '1937-09-21'),
(NEWID(), 'The Alchemist', 'Paulo Coelho', 10.99, 'Adults', '1988-04-01'),
(NEWID(), 'Harry Potter and the Sorcerer''s Stone', 'J.K. Rowling', 14.99, 'Young Adults', '1997-06-26'),
(NEWID(), 'The Catch-22', 'Joseph Heller', 11.50, 'Adults', '1961-11-10'),
(NEWID(), 'The Great Gatsby', 'F. Scott Fitzgerald', 9.99, 'Adults', '1925-04-10'),
(NEWID(), 'Brave New World', 'Aldous Huxley', 8.99, 'Adults', '1932-08-31');


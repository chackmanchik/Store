using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Http;
using System.Xml;
using System.Xml.Linq;


namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-32131","D.Knuth","Art of Programming, Vol. 1", 
                "this volume begins with basic programming concepts...", 7.19m),
            new Book(2,"ISBN 12312-31232","M. Fowler", "Refactoring", 
                "As the application of object technology -- particulary the Java...", 12.45m),
            new Book(3,"ISBN 12312-31233","B.Kernighan, D. Ritchie", "C Programming Language",
                "Known as the bible of C, this classic bestseller introduces...", 14.98m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                       .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();

        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}

﻿using System;
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
            new Book(1,"Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language"),
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();

        }
    }
}
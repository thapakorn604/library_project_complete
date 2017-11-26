using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class BookRepository : IBookRepository
    {

        private static BookRepository _BookRepository = new BookRepository();

        private List<Book> BookList;

        private BookRepository()
        {
            BookList = new List<Book>();
        }

        public static BookRepository Instance => _BookRepository;

    }
}

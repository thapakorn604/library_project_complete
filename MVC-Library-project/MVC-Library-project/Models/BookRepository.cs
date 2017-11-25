using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class BookRepository : IBookRepository
    {

        private static BookRepository BookDepository = new BookRepository();

        private List<Book> BookList;

        private BookRepository()
        {
            BookList = new List<Book>();
        }

        public static BookRepository Instance => BookDepository;

    }
}

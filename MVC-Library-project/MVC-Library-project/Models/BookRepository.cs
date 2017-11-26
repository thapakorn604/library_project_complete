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

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(string bookID)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBookList(string query)
        {
            throw new NotImplementedException();
        }

        public void RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void ReplaceBook(Book previousBook, Book currentBook)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}

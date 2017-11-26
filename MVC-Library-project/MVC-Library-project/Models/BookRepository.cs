using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class BookRepository : IBookRepository
    {

        private static BookRepository _BookRepository = new BookRepository();

        public List<Book> BookList;

        private BookRepository()
        {
            BookList = new List<Book>();
        }

        public static BookRepository Instance => _BookRepository;

        public void AddBook(Book book)
        {
            _BookRepository.BookList.Add(book);
        }

        public Book GetBook(string bookID)
        {
            foreach (Book item in _BookRepository.BookList)
            {
                if (item.ID.Equals(bookID))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Book> GetBookList(string query)
        {
            switch (query.ToLower())
            {
                case "all":
                    return _BookRepository.BookList;
                default:
                    return null;
            }
        }

        public void RemoveBook(Book book)
        {
            _BookRepository.BookList.Remove(book);
        }

        public void ReplaceBook(Book previousBook, Book currentBook)
        {
            int index = -1;
            for (int i = 0; i < _BookRepository.BookList.Count; i++)
            {
                if(_BookRepository.BookList[i].ID.Equals(previousBook))
                {
                    index = i;
                }
            }
            _BookRepository.BookList.Remove(previousBook);
            _BookRepository.BookList.Insert(index, currentBook);

        }

        public int Size()
        {
            return _BookRepository.BookList.Count;
        }
    }
}

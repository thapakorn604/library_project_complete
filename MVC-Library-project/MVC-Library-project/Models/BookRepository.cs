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
            BookList.Add(book);
        }

        public Book GetBook(string bookID)
        {
            foreach (Book item in BookList)
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
                    return BookList;
                default:
                    return null;
            }
        }

        public void RemoveBook(Book book)
        {
            BookList.Remove(book);
        }

        public void ReplaceBook(Book previousBook, Book currentBook)
        {
            int index = -1;
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].ID.Equals(previousBook))
                {
                    index = i;
                }
            }
            BookList.Remove(previousBook);
            BookList.Insert(index, currentBook);

        }

        public int Size()
        {
            return BookList.Count;
        }
    }
}

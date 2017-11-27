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
            BookList.Add(new Book("BOOK-1", "Taduno's Song", "Odafe Atogun", "Canongate Books Ltd", "9781782118138", 240));
            BookList.Add(new Book("BOOK-2", "Wake Me When I'm Gone", "Odafe Atogun", "Canongate Books Ltd", "9781782118428", 208));
            BookList.Add(new Book("BOOK-3", "History of Wolves", "Emily Fridlund", "Grove Press", "9780802127389", 291));
            BookList.Add(new Book("BOOK-4", "What We Lose", "Zinzi Clemmons", "VIKING",  "9780735221710", 213));
            BookList.Add(new Book("BOOK-5", "Home Fire", "Kamila Shamsie", "Riverhead Books", "9780735217683", 276));
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

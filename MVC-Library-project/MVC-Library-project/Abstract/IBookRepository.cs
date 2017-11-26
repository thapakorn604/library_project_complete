using System;
using System.Collections.Generic;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Abstract
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
        void ReplaceBook(Book previousBook, Book currentBook);
        Book GetBook(String bookID);
        List<Book> GetBookList(string query);
        int Size();
    }
}
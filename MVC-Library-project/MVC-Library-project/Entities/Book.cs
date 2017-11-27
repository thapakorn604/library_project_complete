using System;
using System.ComponentModel.DataAnnotations;

namespace MVCLibraryproject.Entities
{
    public class Book
    {
        [Display(Name = "Book ID")]
        public string ID;

        [Display(Name = "Title")]
        public string Title;

        [Display(Name = "Author")]
        public string Author;

        [Display(Name = "Publisher")]
        public string Publisher;

        //[Display(Name = "Category")]
        //public string Category;

        [Display(Name = "ISBN")]
        public string ISBN;

        [Display(Name = "Number of Pages")]
        public int Pages;

        [Display(Name = "Availability")]
        public Boolean IsAvailable;

        public Book(string bookID, string title, string author, string publisher,  string isbn, int pages)
        {
            ID = bookID; Title = title; Author = author; Publisher = publisher; ISBN = isbn; Pages = pages; IsAvailable = true;
        }
    }
}

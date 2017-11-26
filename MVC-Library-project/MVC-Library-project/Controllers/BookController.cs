using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;
using MVCLibraryproject.Models;

namespace MVCLibraryproject.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            BookRepository.Instance.AddBook(book);
            return View();
        }

        [HttpGet]
        public ViewResult Edit(string bookID)
        {
            return View(BookRepository.Instance.GetBook(bookID));
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            foreach (Book item in BookRepository.Instance.GetBookList("all"))
            {
                if (item.ID.Equals(book.ID))
                {
                    BookRepository.Instance.ReplaceBook(item, book);
                }
            }
            return View();
        }

        public ActionResult Delete(string bookID)
        {
            BookRepository.Instance.RemoveBook(BookRepository.Instance.GetBook(bookID));
            return View();
        }
    }
}
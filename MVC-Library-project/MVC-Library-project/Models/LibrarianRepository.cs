using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class LibrarianRepository
    {
        //it has an error
       // private static LibrarianRepository LibrarianRepository = new LibrarianRepository();

        private List<Librarian> LibrarianList;

        private LibrarianRepository()
        {
            LibrarianList = new List<Librarian>();
        }

      //  public static LibrarianRepository Instance => LibrarianRepository;

    }
}

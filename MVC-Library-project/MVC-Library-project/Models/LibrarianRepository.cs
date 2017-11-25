using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class LibrarianRepository
    {

        private static LibrarianRepository LibrarianRepository = new LibrarianRepository();

        private List<Librarian> LibrarianList;

        private LibrarianRepository()
        {
            LibrarianList = new List<Librarian>();
        }

        public static LibrarianRepository Instance => LibrarianRepository;

    }
}

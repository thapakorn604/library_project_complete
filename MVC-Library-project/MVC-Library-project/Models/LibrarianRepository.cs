using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class LibrarianRepository : ILibrarianRepository
    {
        
        private static LibrarianRepository _LibrarianRepository = new LibrarianRepository();

        private List<Librarian> LibrarianList;

        private LibrarianRepository()
        {
            LibrarianList = new List<Librarian>();
        }

        public static LibrarianRepository Instance => _LibrarianRepository;

        public void AddLibrarian(Librarian librarian)
        {
            throw new NotImplementedException();
        }

        public Librarian GetLibrarian(string librarianID)
        {
            throw new NotImplementedException();
        }

        public List<Librarian> GetLibrarianList(string query)
        {
            throw new NotImplementedException();
        }

        public void RemoveLibrarian(Librarian librarian)
        {
            throw new NotImplementedException();
        }

        public void ReplaceLibrarian(Librarian previousLibrarian, Librarian currentLibrarian)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}

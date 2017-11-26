using System;
using System.Collections.Generic;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Abstract
{
    public interface ILibrarianRepository
    {
        void AddLibrarian(Librarian librarian);
        void RemoveLibrarian(Librarian librarian);
        void ReplaceLibrarian(Librarian previousLibrarian, Librarian currentLibrarian);
        Librarian GetLibrarian(String librarianID);
        List<Librarian> GetLibrarianList(string query);
        int Size();
    }
}

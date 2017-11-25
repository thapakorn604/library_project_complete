using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class LibraryRepository : ILibraryRepository
    {

        private static LibraryRepository LibraryRepository = new LibraryRepository();

        private LibraryRepository()
        {
            
        }

    }
}

using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class LibraryRepository : ILibraryRepository
    {

        private static LibraryRepository _LibraryRepository = new LibraryRepository();

        private LibraryRepository()
        {
            
        }

    }
}

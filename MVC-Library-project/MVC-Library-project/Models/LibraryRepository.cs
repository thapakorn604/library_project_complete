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

        public bool Borrow(int memberID, int bookID)
        {
            throw new NotImplementedException();
        }

        public double CalculateFee(int recordID)
        {
            throw new NotImplementedException();
        }

        public bool Return(int recordID)
        {
            throw new NotImplementedException();
        }
    }
}

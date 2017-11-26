using System;
using System.Collections.Generic;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Abstract
{
    public interface ILibraryRepository
    {
        Boolean Borrow(int memberID, int bookID);
        Boolean Return(int recordID);
        double CalculateFee(int recordID);
    }
}

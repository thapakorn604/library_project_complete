using System;
namespace MVCLibraryproject.Entities
{
    public class Record
    {
        public int ID;
        public string BookID;
        public string BookTitle;
        public int MemberID;
        public string MemberName;
        public DateTime BorrowDate;
        public DateTime DueDate;
        public DateTime ReturnDate;
        public Boolean IsOverDue;

        public Record()
        {
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MVCLibraryproject.Entities
{
    public class Record
    {
        [Display(Name = "Record ID")]
        public int ID;

        [Display(Name = "Book ID")]
        public string BookID;

        [Display(Name = "Book Title")]
        public string BookTitle;

        [Display(Name = "Member ID")]
        public int MemberID;

        [Display(Name = "Member Name")]
        public string MemberName;

        [Display(Name = "Borrow Date")]
        public DateTime BorrowDate;

        [Display(Name = "Due Date")]
        public DateTime DueDate;

        [Display(Name = "Return Date")]
        public DateTime ReturnDate;

        [Display(Name = "Overdue")]
        public Boolean IsOverDue;

        public Record()
        {
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MVCLibraryproject.Entities
{
    public class Member
    {
        [Display(Name = "Librarian ID")]
        public string ID;

        [Display(Name = "First Name")]
        public string FirstName;

        [Display(Name = "Last Name")]
        public string LastName;

        [Display(Name = "Phone Number")]
        public string PhoneNumber;

        [Display(Name = "Username")]
        public string Username;

        [Display(Name = "Password")]
        public string Password;

        public Member()
        {
        }
    }
}

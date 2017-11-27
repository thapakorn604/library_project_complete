using System;
using System.ComponentModel.DataAnnotations;

namespace MVCLibraryproject.Entities
{
    public class Librarian
    {
        [Display(Name = "Librarian ID")]
        public string ID;

        [Display(Name = "First Name")]
        public string FirstName;

        [Display(Name = "Last Name")]
        public string LastName;

        [Display(Name = "Gender")]
        public string Gender;

        [Display(Name = "Username")]
        public string Username;

        [Display(Name = "Password")]
        public string Password;

        public Librarian(string librarianID, string firstName, string lastName, string gender, string username, string password)
        {
            ID = librarianID; FirstName = firstName; LastName = lastName; Gender = gender; Username = username; Password = password;
        }
    }
}

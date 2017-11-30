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

        [Display(Name = "Gender")]
        public string Gender;

        [Display(Name = "Phone Number")]
        public string PhoneNumber;

        [Display(Name = "Username")]
        public string Username;

        [Display(Name = "Password")]
        public string Password;





        public Member(string memberID, string firstName, string lastName, string gender, 
                      string phoneNumber, string username, string password)
        {
            ID = memberID; FirstName = firstName; LastName = lastName; Gender = gender; 
            PhoneNumber = phoneNumber; Username = username; Password = password;
        }
    }
}

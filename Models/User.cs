using System;

namespace BudgetBuddy.Models
{
    public class User
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor
        public User(string firstName, string lastName, string email, DateTime dateOfBirth, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}


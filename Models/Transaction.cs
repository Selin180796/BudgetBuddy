using System;

namespace BudgetBuddy.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        // Foreign key to the User model
        public int UserId { get; set; }
        public User User { get; set; }

        // Foreign key to the Category model
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}


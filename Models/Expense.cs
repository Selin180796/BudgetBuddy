using System;

namespace BudgetBuddy.Models
{
    /// <summary>
    /// Represents an expense entry in the BudgetBuddy application.
    /// Attributes:
    /// ExpenseID: Unique identifier for the expense.
    /// UserID: Identifier for the user who made the expense.
    /// Amount: Amount spent in the expense.
    /// Category: Category of the expense (e.g., Food, Transport).
    /// Date: Date when the expense was made.
    /// Description: Description of the expense.
    /// </summary>
    public class Expense
    {
        public string ExpenseID { get; set; }
        public string UserID { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}

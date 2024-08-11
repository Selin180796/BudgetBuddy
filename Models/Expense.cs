namespace BudgetBuddy.Models
{
    public class Expense
    {
        public string ExpenseID { get; set; }
        public string UserID { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }

        public Expense(string expenseID, string userID, Category category, string description)
        {
            ExpenseID = expenseID;
            UserID = userID;
            Category = category;
            Description = description;
        }
    }
}

namespace BudgetBuddy.Models
{
    public class Transaction
    {
        public string Description { get; set; }
        public string User { get; set; }
        public Category Category { get; set; }

        public Transaction(string description, string user, Category category)
        {
            Description = description;
            User = user;
            Category = category;
        }
    }
}

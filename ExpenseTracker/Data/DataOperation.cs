namespace ExpenseTracker.Data
{
    public class DataOperation
    {
        public List<Expense> Expenses = new();

        public void Add(string date, decimal amount, string description, string category)
        {
            Expense expense = new Expense()
            {
                Date = date,
                Amount = amount,
                Description = description,
                Category = category
            };
            Expenses.Add(expense);
        }
    }
}

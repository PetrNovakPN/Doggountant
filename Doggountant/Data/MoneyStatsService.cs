namespace Doggountant.Data
{
    internal class MoneyStatsService
    {
        public decimal TotalValue { get; set; }

        public decimal IncomeValue { get; set; }

        public decimal ExpenseValue { get; set; }

        public void SetTotalValue(decimal totalValue)
        {
            TotalValue = totalValue;
        }

        public void SetIncomeValue(decimal incomeValue)
        {
            IncomeValue = incomeValue;
        }

        public void SetExpenseValue(decimal expenseValue)
        {
            ExpenseValue = expenseValue;
        }

        public decimal GetTotalValue()
        {
            return TotalValue;
        }

        public decimal GetIncomeValue()
        {
            return IncomeValue;
        }

        public decimal GetExpenseValue()
        {
            return ExpenseValue;
        }
    }
}
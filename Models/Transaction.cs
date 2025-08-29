namespace FinancialSystem.Models;
// Class that represents a financial transaction
public class Transaction
{
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public decimal Amount { get; set; } // Positive for inputs, negative for outputs

    public Transaction(DateTime date, string description, decimal amount)
    {
        Date = date;
        Description = description;
        Amount = amount; 
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Description}: {Amount:C}";
    }
}

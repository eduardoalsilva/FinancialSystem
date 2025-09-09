namespace FinancialSystem.Models;

// Base class for accounts and investiments
public abstract class FinancialEntity
{
    public string? Name { get; set; }
    public decimal Balance { get; protected set; } 
    public List<Transaction> Transactions { get; } = new List<Transaction>();

    protected FinancialEntity(string name)
    {
        Name = name;
        Balance = 0;
    }

    // Transactions can be positive for deposit or negative for withdrawal
    public void AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);
        Balance += transaction.Amount;
    }

    public void DisplayHistory()
    {
        Console.WriteLine($"Histórico de {Name}:");
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }

        Console.WriteLine($"Saldo atual: {Balance:C}\n");
    }
}

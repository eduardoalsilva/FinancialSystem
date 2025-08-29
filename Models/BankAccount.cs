namespace FinancialSystem.Models;

// Class for Bank Account
public class BankAccount : FinancialEntity
{
    public BankAccount(string name) : base(name)
    {
    }

    public void Deposit(decimal amount, string description = "Depósito")
    {
        if (amount <= 0) throw new ArgumentException("Depósito deve ser positivo.");
        AddTransaction(new Transaction(DateTime.Now, description, amount));
    }

    public void Withdraw(decimal amount, string description = "Saque")
    {
        if (amount <= 0) throw new ArgumentException("Saque deve ser positivo.");
        if (Balance < amount) throw new InvalidOperationException("Saldo insuficiente");
        AddTransaction(new Transaction(DateTime.Now, description, -amount));
    }
}

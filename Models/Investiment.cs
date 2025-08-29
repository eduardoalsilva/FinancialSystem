namespace FinancialSystem.Models;

// Class for investiment
public class Investiment : FinancialEntity
{
    public string Type { get; set; } // e.g.: Stocks, Bonds, Funds 
    public Investiment(string name, string type) : base(name)
    {
        Type = type;
    }

    public void Invest(decimal amount, string description = "Investimento")
    {
        if (amount <= 0) throw new ArgumentException("Valor de investimento deve ser positivo.");
        AddTransaction(new Transaction(DateTime.Now, description, amount));
    }

    public void Sell(decimal amount, string description = "Venda")
    {
        if (amount <= 0) throw new ArgumentException("Valor de venda deve ser positivo.");
        if (Balance < amount) throw new InvalidOperationException("Valor insuficiente para venda.");
        AddTransaction(new Transaction(DateTime.Now, description, -amount));
    }

    public void UpdateValue(decimal newValue, string description = "Atualização de Valor")
    {
        decimal difference = newValue - Balance;
        AddTransaction(new Transaction(DateTime.Now, description, difference));
    }

}
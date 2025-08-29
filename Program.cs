using FinancialSystem.Models;

Console.WriteLine("Bem vindo ao FinancialSystem, um sistema de fiscalização financeira simples\n");

var checkingAccount = new BankAccount("Conta Corrente");
checkingAccount.Deposit(1800, "Salário");
checkingAccount.Withdraw(200, "Pagamento de conta");
checkingAccount.DisplayHistory();

var stockInvestiment = new Investiment("Ações Tech", "Ações");
stockInvestiment.Invest(5000, "Compra inicial");
stockInvestiment.UpdateValue(5500, "Apreciação");
stockInvestiment.Sell(1000, "Venda parcial");
stockInvestiment.DisplayHistory();

Console.WriteLine("FinancialSystem encerrado");
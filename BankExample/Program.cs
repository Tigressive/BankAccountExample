// See https://aka.ms/new-console-template for more information


using BankExample;

BankAccount bankAccount = new BankAccount(1000);


bankAccount.Deposit(1000);
bankAccount.Withdraw(500);

Console.WriteLine(bankAccount.GetBalance());
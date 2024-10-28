namespace BankExample;

public class BankAccount
{
    private int balance;

    public BankAccount(int balance)
    {
        this.balance = balance;
    }

    public void Deposit(int amount)
    {
        balance += amount;
    }

    public void Withdraw(int amount)
    {
        balance -= amount;
    }

    public int GetBalance()
    {
        return balance;
    }
}
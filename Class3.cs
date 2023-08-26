using System;

class BankAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
        }
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

sealed class SavingsAccount : BankAccount
{
    private decimal interestRate;

    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        : base(accountNumber, initialBalance)
    {
        this.interestRate = interestRate;
    }

    public void CalculateInterest()
    {
        decimal interest = Balance * interestRate;
        Console.WriteLine($"Interest calculated: {interest:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("123456", 1000);
        account1.Deposit(500);
        account1.Withdraw(200);

        SavingsAccount savingsAccount = new SavingsAccount("789012", 2000, 0.05M);
        savingsAccount.Deposit(1000);
        savingsAccount.CalculateInterest();
        Console.ReadLine();
    }
}
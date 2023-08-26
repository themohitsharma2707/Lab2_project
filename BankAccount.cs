using System;

class BankAccount
{

    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public int Balance { get; private set; }

    public BankAccount(int accountNumber, string accountHolderName, int initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }


    public void Withdraw(int amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }


    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Details:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Account Number: ");
        int accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        string accountHolderName = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        int initialBalance = Convert.ToInt32(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, accountHolderName, initialBalance);


        account.DisplayAccountDetails();

        Console.Write("Enter Deposit Amount: ");
        int depositAmount = Convert.ToInt32(Console.ReadLine());
        account.Deposit(depositAmount);

        Console.Write("Enter Withdrawal Amount: ");
        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
        account.Withdraw(withdrawalAmount);

        account.DisplayAccountDetails();
        Console.ReadLine();
    }
}
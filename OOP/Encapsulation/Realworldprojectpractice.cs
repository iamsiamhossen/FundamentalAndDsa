using System;
public class BankAccount
{
    public string accountHolderName { get; private set; }
    public string accountNumber { get; private set; }
    public decimal balance { get; private set; }

    public BankAccount(string accountHolderName, string accountNumber, decimal initialBalance)
    {

        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        if (initialBalance < 0)
        {
            Console.WriteLine("Invalid Negative balance");
            // this.balance = 0;
        }
        else
        {
            this.balance = initialBalance;
            Console.WriteLine("Bank Account Created Successfully!");
        }

    }
    //check balance method
    public decimal CheckBalance()
    {
        return balance;
    }

    // Method to Deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount too low.");
            return;
        }
        else
        {
            balance += amount;
            Console.WriteLine($" deposited {amount:C}. New balance: {balance:C}");
        }
    }
    public void withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid Amount");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($" withdraw {amount:C}. New balance: {balance:C}");
        }
    }


}
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount siam = new BankAccount("Siam Hossen", "1001", 5000);

        Console.WriteLine("\nBANK ACCOUNT SYSTEM");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check Balance");
        Console.WriteLine("4. Account Details");

        Console.Write("\nChoose an option: ");
        string? choice = Console.ReadLine();

        switch (choice?.ToLower())
        {
            case "1":
            case "deposit":
                Console.Write("Enter deposit amount: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    siam.Deposit(depositAmount);
                else
                    Console.WriteLine("Invalid amount.");
                break;

            case "2":
            case "withdraw":
                Console.Write("Enter withdrawal amount: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    siam.withdraw(withdrawAmount);
                else
                    Console.WriteLine("Invalid amount.");
                break;

            case "3":
            case "checkbalance":
                Console.WriteLine($"Current Balance: {siam.CheckBalance():C}");
                break;

            case "4":
            case "accountdetails":
                Console.WriteLine($"Account Holder: {siam.accountHolderName}");
                Console.WriteLine($"Account Number: {siam.accountNumber}");
                Console.WriteLine($"Current Balance: {siam.CheckBalance():C}");
                break;

            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}

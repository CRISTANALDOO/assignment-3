using System;

public class BankAccount
{
    private int accountNumber;
    private double balance;
    private string type;

    // Default constructor for a checking account
    public BankAccount(int accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0.0;
        this.type = "Checking";
    }

    // Constructor for a savings account
    public BankAccount(int accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
        this.type = "Savings";
    }

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"{amount} deposited into account #{accountNumber}");
    }
  // Method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount} withdrawn from account #{accountNumber}");
        }
        else
        {
            Console.WriteLine("Insufficient funds in account #{accountNumber}");
        }
    }

    // Display account details
    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Type: " + type);
        Console.WriteLine("Balance: $" + balance);
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        BankAccount checkingAccount = new BankAccount(1001);
        checkingAccount.Deposit(1200);
        checkingAccount.Withdraw(4500);
        checkingAccount.DisplayAccountInfo();

        BankAccount savingsAccount = new BankAccount(2001, 5000);
        savingsAccount.Withdraw(2000);
        savingsAccount.Deposit(1500);
        savingsAccount.DisplayAccountInfo();
    }
}

using System;
public class BankAcc
{
    public string name { get; set; }
    public string acc { get; }
    private int balance; //need manual write for validation
    public BankAcc(string name, string acc, int balance)
    {
        this.name = name;
        this.acc = acc;
        this.balance = balance;
    }
    public int Balance //property er parameter newa jayna 
    {
        get { return balance; }
        set
        {
            balance = value;
        }
    }

}
public class Program
{
    public static void Main()
    {
        BankAcc siam = new BankAcc("SiamHossen", "062222", 1000);
        Console.WriteLine(siam.name);
        Console.WriteLine(siam.Balance);
        siam.Balance = 2000;
        Console.WriteLine(siam.Balance);

    }
}
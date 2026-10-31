using System;
public class Bank
{
    public string name;
    public string ACNO;
    private int balance;

    public Bank(string name, string ACNO, int balance)
    {
        this.name = name;
        this.ACNO = ACNO;
        this.balance = balance;
    }
    public int Seebalance()
    {
        return balance;
    }
    public void Accessinbalance(int val)
    {
        if (val > balance)
        {
             Console.WriteLine("Insufficient Balance ! Sorry");
        }
        else
        {
             Console.WriteLine("Successfully Access In Balance.");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Bank siam = new Bank("Siam Hossen", "44135091", 10000);
        // Console.WriteLine(siam.balance);//Normally non accesible balance because balance are private here 
        //so we need here some updates 
        Console.WriteLine(siam.Seebalance());
        siam.Accessinbalance(200);


    }
}
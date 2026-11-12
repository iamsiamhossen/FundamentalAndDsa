using System;
public class PaymentMethod
{
    public int paymentAmount { get; private set; }

    public PaymentMethod(int paymentAmount)
    {
        this.paymentAmount = paymentAmount;
    }
    public virtual void ProcessPayment()
    {
        Console.WriteLine($"Payment of {paymentAmount} processed.");
    }
}
public class CreditCard : PaymentMethod
{
    public string Name { get; private set; }

    public CreditCard(int paymentAmount, string name) : base(paymentAmount)
    {
        this.Name = name;
    }
    public override void ProcessPayment()
    {
        // Show Cardholder Name and Payment Amount
        Console.WriteLine($"Cardholder Name: {Name}");
        Console.WriteLine($"Payment of {paymentAmount} processed using Credit Card.");
    }
}

public class MobileBanking : PaymentMethod
{
    public string MobileNumber { get; private set; }

    public MobileBanking(int paymentAmount, string mobileNumber) : base(paymentAmount)
    {
        this.MobileNumber = mobileNumber;
    }
    public override void ProcessPayment()
    {
        // Show Mobile Number and Payment Amount
        Console.WriteLine($"Mobile Number: {MobileNumber}");
        Console.WriteLine($"Payment of {paymentAmount} processed using Mobile Banking.");
    }
}
public class BankTransfer : PaymentMethod
{
    public string BankName { get; private set; }

    public BankTransfer(int paymentAmount, string BankName) : base(paymentAmount)
    {
        this.BankName = BankName;
    }
    public override void ProcessPayment()
    {
        // Show Bank Name and Payment Amount
        Console.WriteLine($"Bank Name: {BankName}");
        Console.WriteLine($"Payment of {paymentAmount} processed using Bank Transfer.");
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {
        PaymentMethod[] payments = new PaymentMethod[]
        {
            new CreditCard(5000, "Siam Hossen"),
            new MobileBanking(2000, "123-456-7890"),
            new BankTransfer(10000, "ABC Bank")
        };

        foreach (PaymentMethod x in payments)
        {
            x.ProcessPayment();
            Console.WriteLine();
        }
    }
}
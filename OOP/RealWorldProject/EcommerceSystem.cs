using System;
public class User
{
    public int userId { get; private set; }
    public string name { get; private set; }
    public string email { get; private set; }
    private String _password;
    public User(int userId, string name, string email, string _password)
    {
        changeEmail(email); // Validate and set email
        this.name = name;
        this.userId = userId;
        changePassword(_password); // Validate and set password
    }
    public void changeEmail(string newEmail)
    {
        // Validate the new email format before changing it
        if (!newEmail.Contains("@"))
        {
            throw new ArgumentException("Invalid email format.");
        }
        this.email = newEmail;
    }
    public void changePassword(string newPassword)
    {
        // Validate the new password strength before changing it
        if (newPassword.Length < 6)
        {
            throw new ArgumentException("Password must be at least 6 characters long.");
        }
        this._password = newPassword;
    }
    public void displayUserInfo()
    {
        Console.WriteLine($"User ID: {userId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
    }
}
public class Customer : User
{
    public string shippingAddress { get; private set; }
    public string phoneNumber { get; private set; }

    public Customer(string shippingAddress, string phoneNumber, int userId, string name, string email, string _password) : base(userId, name, email, _password)
    {
        this.shippingAddress = shippingAddress;
        this.phoneNumber = phoneNumber;
    }
    public void updateShippingAddress(string newAddress)
    {
        this.shippingAddress = newAddress;
    }
    public void displayCustomerInfo()
    {
        displayUserInfo();
        Console.WriteLine($"Shipping Address: {shippingAddress}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
    }
}
public class Admin : User
{
    public string role { get; private set; }
    public bool CanManageProducts { get; private set; }
    public Admin(string role, bool canManageProducts, int userId, string name, string email, string _password) : base(userId, name, email, _password)
    {
        displayUserInfo();
        Console.WriteLine($"Role: {role}");
        Console.WriteLine($"Can Manage Products: {canManageProducts}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Create a Customer object
        Customer customer = new Customer("123 Main St", "555-1234", 1, "SiamHossen", "iamsiamhossen@gmail.com", "password123");
        customer.displayCustomerInfo();
        Admin admin = new Admin("Admin", true, 29, "SiamHossen", "iamsiamhossen@gmail.com", "1234@far");

    }
}

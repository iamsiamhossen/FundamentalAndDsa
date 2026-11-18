using System;
public class Category
{
    public int CategoryId { get; private set; }
    public string CategoryName { get; private set; }

    public Category(int CategoryId, string CategoryName)
    {
        this.CategoryId = CategoryId;
        this.CategoryName = CategoryName;
    }
}
public class Product
{
    public int ProductId { get; private set; }
    public string ProductName { get; private set; }
    public decimal Price { get; private set; }
    public Category ProductCategory { get; private set; }

    public Product(int ProductId, string ProductName, decimal Price, Category ProductCategory)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.Price = Price;
        this.ProductCategory = ProductCategory;
    }
    public void displayinfo()
    {
        Console.WriteLine($"ProductName: {ProductName}");
        Console.WriteLine($"ProductID: {ProductId}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Category: {ProductCategory.CategoryName}");
    }

}
public class Main
{
    public static void main(string[] args)
    {
        Category electronics = new Category(29, "Television");
        Product product = new Product(29, "Television", 500, electronics);
        product.displayinfo();
    }
}
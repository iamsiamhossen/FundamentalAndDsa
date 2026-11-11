using System;
public class Person //Base class
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }

    public Person(string name, int age, int id, string email)
    {
        Name = name;
        Age = age;
        Id = id;
        Email = email;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Id: {Id}, Email: {Email}");
    }
}
public class Student : Person //Derived Or Child class
{

    public int marks { get; set; }

    public Student(string name, int age, int id, string email, int marks) : base(name, age, id, email) //base keyword is used to call the constructor of the base class
    {
        this.marks = marks;
    }

    public void GetMarks()
    {
        Console.WriteLine($"Marks: {marks}");
    }

}

public class mainClass
{
    public static void Main(string[] args)
    {
        Student student = new Student("Siam Hossen", 24, 530191, "iamsiamhossen@gmail.com", 85);
        student.DisplayInfo();
        student.GetMarks();
    }
}
using System;
public class Commonfield
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }
    public Commonfield(string name, int age, int id, string email)
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
public class Teacher : Commonfield
{
    public string subject { get; set; }
    public Teacher(string name, int age, int id, string email, string subject) : base(name, age, id, email)
    {
        this.subject = subject;
    }
    public void showallinfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Subject: {subject}");
    }
}
public class Student : Commonfield
{
    public int marks { get; set; }
    public Student(string name, int age, int id, string email, int marks) : base(name, age, id, email)
    {
        this.marks = marks;
    }
    public void showallinfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Marks: {marks}");
    }
}
public class main
{
    public static void Main(string[] args)
    {
        Student siam = new Student("Siam Hoseen", 24, 530191, "iamsiamhossen@gmail.com", 85);
        Teacher tanvir = new Teacher("Tanvir Hossen", 30, 530192, "tanvirhossen@gmail.com", "Mathematics");
        siam.showallinfo();
        tanvir.showallinfo();
    }
}
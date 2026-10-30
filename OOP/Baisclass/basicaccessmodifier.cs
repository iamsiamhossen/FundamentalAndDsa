using System;
public class Student
{
    private int id;
    private string name;
    private string address;
    private string phoneNumber;
    private string bloodGroup;

    public Student(int id, string name, string address, string phoneNumber, string bloodGroup)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.bloodGroup = bloodGroup;
    }
    public void print()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Address: {address}, Phone: {phoneNumber}, Blood Group: {bloodGroup}");
    }
}
public class program
{
    public static void Main(string[] args)
    {
        Student student = new Student(29, "SiamHossen", "Shahjadpur,Sirajganj", "01400695621", "B+");
        student.print();
    }
}
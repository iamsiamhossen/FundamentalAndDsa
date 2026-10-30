using System;
public class Student
{
    public int Id { get; set; } // Property for student ID
    public string Name { get; set; } // Property for student name
    public Student(int id, string name) // Constructor
    {
        Id = id;
        Name = name;
        Console.WriteLine("Student constructor called. "); // Print a message
        Console.WriteLine($"Student ID: {Id},Student Name: {Name}"); // Print the student ID and name
    }
}
public class Program
{
    public static void Main(string[] args) // Main method
    {
        Student student = new Student(29, "SiamHossen"); // Create a Student object
        Console.WriteLine("Student object created successfully."); //Print a message
    }
}
    
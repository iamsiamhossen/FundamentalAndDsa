using System;

public class Student
{
    public string name = " ";
}

public class Programme
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        s.name = "Siam";
        Console.WriteLine(s.name);
    }
}
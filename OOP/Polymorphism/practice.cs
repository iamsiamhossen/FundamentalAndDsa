using System;
public class Teacher
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Id { get; private set; }

    public Teacher(string name, int age, int id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
    //Method to apply polymorphism
    public virtual void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Id: {Id}");
    }
}
public class seniorTeacher : Teacher
{
    public string Designation { get; private set; }
    public seniorTeacher(string name, int age, int id, string designation) : base(name, age, id)
    {
        this.Designation = designation;
    }
    //Method to apply polymorphism
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Designation: {Designation}");
    }
}
public class Student : Teacher
{
    public int marks { get; private set; }
    public Student(string name, int age, int id, int marks) : base(name, age, id)
    {
        this.marks = marks;
    }
    //Method to apply polymorphism
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Marks: {marks}");
    }
}
public class mainclass
{
    public static void Main(string[] args)
    {
        Teacher[] data = new Teacher[]
        {
            new seniorTeacher("Tanvir Hossen", 30, 530192, "Mathematics"),
            new Student("Siam Hossen", 24, 530191, 85)
        };
        foreach (Teacher item in data)
        {
            item.Display();
        }
    }
}
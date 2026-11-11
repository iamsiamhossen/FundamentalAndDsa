using System;
public class Employee
{
    public int id { get; private set; }
    public string name { get; private set; }
    public string department { get; private set; }

    public Employee(int id, string name, string department)
    {
        this.id = id;
        this.name = name;
        this.department = department;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {id}, Name: {name}, Department: {department}");
    }
}
public class FullTime : Employee
{
    public double MonthlySalary { get; private set; }

    public FullTime(int id, string name, string department, double monthlySalary) : base(id, name, department)
    {
        this.MonthlySalary = monthlySalary;
    }
    public void CalculateSalary()
    {
        Console.WriteLine($"Monthly Salary: {MonthlySalary}");
    }
}
public class PartTime : Employee
{
    public double HourlyRate { get; private set; }
    public double workinghours { get; private set; }

    public PartTime(int id, string name, string department, double hourlyRate, double workinghours) : base(id, name, department)
    {
        this.HourlyRate = hourlyRate;
        this.workinghours = workinghours;
    }
    public double CalculateSalary()
    {
        return HourlyRate * workinghours;
    }
}
public class intern : Employee
{
    public double stipend { get; private set; }

    public intern(int id, string name, string department, double stipend) : base(id, name, department)
    {
        this.stipend = stipend;
    }
    public void CalculateStipend()
    {
        Console.WriteLine($"Stipend: {stipend}");
    }
}
public class mainclass
{
    public static void Main(string[] args)
    {
        Employee employee = new FullTime(101, "Siam", "Backend", 50000);
        // Employee partTimeEmployee = new PartTime(102, "Rahim", "Development", 500, 80);
        // Employee internEmployee = new intern(103, "Karim", "QA", 10000);
        employee.DisplayInfo();
        // employee.CalculateSalary();
        // partTimeEmployee.DisplayInfo();
        // partTimeEmployee.CalculateSalary();
        // internEmployee.DisplayInfo();
        // internEmployee.CalculateStipend();
    }
}
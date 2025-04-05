using System;

// Interface
interface IWork
{
    void ShowWork();
}

// Abstract class
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Display();
}

// Base class
class Employee : Person, IWork
{
    public int EmployeeId { get; set; }
    public string Department { get; set; }

    // Static constructor
    static Employee()
    {
        Console.WriteLine("Static Constructor: Employee class initialized.");
    }

    // Public constructor
    public Employee(string name, int age, int empId, string dept) : base(name, age)
    {
        EmployeeId = empId;
        Department = dept;
    }

    // Virtual method
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, ID: {EmployeeId}, Department: {Department}");
    }

    // Implementing interface method
    public void ShowWork()
    {
        Console.WriteLine($"{Name} is working in {Department} department.");
    }

    public override void Display()
    {
        Console.WriteLine("Displaying Employee Details...");
    }
}

// Derived class
class Manager : Employee
{
    public string Role { get; set; }

    public Manager(string name, int age, int empId, string dept, string role)
        : base(name, age, empId, dept)
    {
        Role = role;
    }

    // Overriding virtual method
    public override void ShowDetails()
    {
        Console.WriteLine($"Manager: {Name}, Age: {Age}, ID: {EmployeeId}, Department: {Department}, Role: {Role}");
    }

    // Using new keyword to hide base class method
    public new void ShowWork()
    {
        Console.WriteLine($"{Name} is managing the {Department} department as a {Role}.");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Sunil", 30, 101, "IT");
        emp.ShowDetails();
        emp.ShowWork();
        emp.Display();

        Console.WriteLine();

        Manager mgr = new Manager("Rathod", 35, 201, "Manager", "HR Head");
        mgr.ShowDetails();
        mgr.ShowWork();
        mgr.Display();
    }
}

// create a class called employee that inherits from person and adds a method Employee_details than , create another class called manager that inherits from Employee and adds a method department.
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Employee : Person
{
    public string EmployeeID { get; set; }

    public Employee(string name, int age, string employeeID) : base(name, age)
    {
        EmployeeID = employeeID;
    }

    public void EmployeeDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Employee ID: {EmployeeID}");
    }
}

class Manager : Employee
{
    public string DepartmentName { get; set; }

    public Manager(string name, int age, string employeeID, string departmentName)
        : base(name, age, employeeID)
    {
        DepartmentName = departmentName;
    }

    public void Department()
    {
        Console.WriteLine($"Department: {DepartmentName}");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("Alice Johnson", 35, "E102", "Human Resources");
        manager.EmployeeDetails();
        manager.Department();
    }
}

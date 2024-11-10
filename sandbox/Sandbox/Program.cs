using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}

public class Employee
{
    protected string _name;
    protected float _pay;
    public Employee(string name)
        {
            _name = name;
            _pay = 0;
        }

    public float CalculatePay()
    {
        return _pay;
    }

    
}

public class Salary : Employee
{
    protected float _salary;
    public Salary(string name, float salary) : base(name)
    {
        _salary = salary;
        _pay = _salary;
    }
}

public class Hourly : Employee
{
    protected float _hours;
    public Hourly(string name,float hours, float pay) : base(name)
    {
        
    }
}

public class Volunteer : Employee
{

}
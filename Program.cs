using System;
using System.Collections.Generic;

abstract class Employee
{
    public string Name;
    public int Id;
    public string Position;
    public abstract double CalcSalary();
}

class Worker : Employee
{
    public double Rate;
    public int Hours;
    public override double CalcSalary() => Rate * Hours;
}

class Manager : Employee
{
    public double BaseSalary;
    public double Bonus;
    public override double CalcSalary() => BaseSalary + Bonus;
}

class Program
{
    static void Main()
    {
        List<Employee> emps = new List<Employee>
        {
            new Worker { Name="Иван", Id=1, Position="Рабочий", Rate=100, Hours=160 },
            new Manager { Name="Мария", Id=2, Position="Менеджер", BaseSalary=50000, Bonus=10000 },
            new Worker { Name="Петр", Id=3, Position="Рабочий", Rate=120, Hours=150 }
        };

        foreach (var e in emps)
            Console.WriteLine($"{e.Name} ({e.Position}) зарплата: {e.CalcSalary()}");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    protected string _surname;
    protected string _name;

    public Employee(string surname, string name)
    {
        _surname = surname;
        _name = name;
    }

    public double CalculateSalary(string position, int experience)
    {
        double salary = 0;

        switch (position)
        {
            case "Директор":
                salary = 100000;
                break;
            case "Програміст":
                salary = 50000;
                break;
            case "Інженер":
                salary = 40000;
                break;
            case "Бухгалтер":
                salary = 30000;
                break;
        }

        if (experience > 5)
        {
            salary *= 1.1;
        }

        return salary;
    }

    public double CalculateTax(double salary)
    {
        return salary * 0.25;
    }
}


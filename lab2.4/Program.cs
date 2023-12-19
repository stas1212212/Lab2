using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    private string _login;
    private string _name;
    private string _surname;
    private int _age;
    private readonly DateTime _dateOfFilling;

    public User(string login, string name, string surname, int age)
    {
        _login = login;
        _name = name;
        _surname = surname;
        _age = age;
        _dateOfFilling = DateTime.Now;
    }

    public string Login
    {
        get { return _login; }
    }

    public string Name
    {
        get { return _name; }
    }

    public string Surname
    {
        get { return _surname; }
    }

    public int Age
    {
        get { return _age; }
    }

    public DateTime DateOfFilling
    {
        get { return _dateOfFilling; }
    }

    public void PrintInfo()
    {
        Console.WriteLine("Логін: {0}", _login);
        Console.WriteLine("Ім'я: {0}", _name);
        Console.WriteLine("Прізвище: {0}", _surname);
        Console.WriteLine("Вік: {0}", _age);
        Console.WriteLine("Дата заповнення анкети: {0}", _dateOfFilling);
    }
}


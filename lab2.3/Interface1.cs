using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса Employee
        Employee employee = new Employee("Іванов", "Петро");

        // Рассчитываем оклад сотрудника
        double salary = employee.CalculateSalary("Програміст", 10);

        // Рассчитываем налог на доходы сотрудника
        double tax = employee.CalculateTax(salary);

        // Выводим на экран информацию о сотруднике
        Console.WriteLine("Прізвище: {0}", employee._surname);
        Console.WriteLine("Ім'я: {0}", employee._name);
        Console.WriteLine("Посада: {0}", "Програміст");
        Console.WriteLine("Оклад: {0}", salary);
        Console.WriteLine("Податковий збір: {0}", tax);

        // Завершаем работу программы
        Console.ReadKey();
    }
}

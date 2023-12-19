using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса User
        User user = new User("user1", "Іван", "Петров", 30);

        // Выводим на экран информацию о пользователе
        user.PrintInfo();

        // Завершаем работу программы
        Console.ReadKey();
    }
}


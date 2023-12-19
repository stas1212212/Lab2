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
        // Создаем объект класса Converter
        Converter converter = new Converter(28.0, 30.0, 4.0);

        // Конвертируем гривні в доллары США
        double usd = converter.ConvertUAHToUSD(1000);
        Console.WriteLine("1000 гривень в доларах США: {0}", usd);

        // Конвертируем гривні в евро
        double eur = converter.ConvertUAHToEUR(1000);
        Console.WriteLine("1000 гривень в євро: {0}", eur);

        // Конвертируем гривні в польские злотые
        double pln = converter.ConvertUAHToPLN(1000);
        Console.WriteLine("1000 гривень в польські злоті: {0}", pln);

        // Конвертируем доллары США в гривні
        double uah = converter.ConvertUSDToUAH(100);
        Console.WriteLine("100 доларів США в гривні: {0}", uah);

        // Конвертируем евро в гривні
        double uah2 = converter.ConvertEURToUAH(100);
        Console.WriteLine("100 євро в гривні: {0}", uah2);

        // Конвертируем польские злотые в гривні
        double uah3 = converter.ConvertPLNToUAH(100);
        Console.WriteLine("100 польських злотих в гривні: {0}", uah3);

        // Завершаем работу программы
        Console.ReadKey();
    }
}


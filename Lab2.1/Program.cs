
using System;

namespace AllClasses
{
    class Converter
    {
        private double _usd;
        private double _eur;
        private double _pln;

        public Converter(double usd, double eur, double pln)
        {
            _usd = usd;
            _eur = eur;
            _pln = pln;
        }

        public double ConvertToUSD(double amount)
        {
            return amount / _usd;
        }

        public double ConvertToEUR(double amount)
        {
            return amount / _eur;
        }

        public double ConvertToPLN(double amount)
        {
            return amount / _pln;
        }

        public double ConvertFromUSD(double amount)
        {
            return amount * _usd;
        }

        public double ConvertFromEUR(double amount)
        {
            return amount * _eur;
        }

        public double ConvertFromPLN(double amount)
        {
            return amount * _pln;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо екземпляр класу Converter
            Converter converter = new Converter(29.25, 31.17, 3.96);

            // Конвертуємо 100 гривень у долари США
            double usd = converter.ConvertToUSD(100);
            Console.WriteLine("100 гривень = {0} доларів США", usd);

            // Конвертуємо 100 гривень у євро
            double eur = converter.ConvertToEUR(100);
            Console.WriteLine("100 гривень = {0} євро", eur);

            // Конвертуємо 100 гривень у польські злоті
            double pln = converter.ConvertToPLN(100);
            Console.WriteLine("100 гривень = {0} польських злотих", pln);

            // Конвертуємо 10 доларів США у гривні
            double grn = converter.ConvertFromUSD(10);
            Console.WriteLine("10 доларів США = {0} гривень", grn);

            // Конвертуємо 10 євро у гривні
            grn = converter.ConvertFromEUR(10);
            Console.WriteLine("10 євро = {0} гривень", grn);

            // Конвертуємо 10 польських злотих у гривні
            grn = converter.ConvertFromPLN(10);
            Console.WriteLine("10 польських злотих = {0} гривень", grn);

            // Завершуємо роботу програми
            Console.ReadKey();
        }
    }
}


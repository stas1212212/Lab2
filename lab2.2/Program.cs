using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Converter
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

    public double ConvertUAHToUSD(double amount)
    {
        return amount / _usd;
    }

    public double ConvertUAHToEUR(double amount)
    {
        return amount / _eur;
    }

    public double ConvertUAHToPLN(double amount)
    {
        return amount / _pln;
    }

    public double ConvertUSDToUAH(double amount)
    {
        return amount * _usd;
    }

    public double ConvertEURToUAH(double amount)
    {
        return amount * _eur;
    }

    public double ConvertPLNToUAH(double amount)
    {
        return amount * _pln;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency {

    public string CurrencyCode { get; set; }
    public static CurrencyConversionRate Rates { get; set; }
    private static CurrencyConversionRate MemoryRates { get; set; }
    private static CurrencyConversionRate UserRates { get; set; }

    public Currency(string code)
    {
        CurrencyCode = code;
        MemoryRates = new CurrencyConversionRate();
        UserRates = new CurrencyConversionRate();
        Rates = MemoryRates;
    }

    public double GetConversionRateFrom(string targetCurrencyCode)
    {
        return Rates.GetConversionFrom(this.CurrencyCode, targetCurrencyCode);
    }

    public decimal GetConversionFrom(string targetCurrencyCode, decimal price)
    {
        return  price * (decimal) Rates.GetConversionFrom(this.CurrencyCode, targetCurrencyCode);
    }

    public decimal GetPriceInUSD(decimal price)
    {
        return price * (decimal) Rates.GetConversionFrom(this.CurrencyCode, "USD");
    }

    public decimal GetPriceFromUSD(decimal price)
    {
        return price * (decimal)Rates.GetConversionFrom("USD", this.CurrencyCode);
    }

    public static void UseCustomValues()
    {
        Rates = UserRates;
    }

    public static void UseMemoryValues()
    {
        Rates = MemoryRates;
    }

    public static void ChangeRate(string currencyCode, double rate)
    {
        UserRates.ChangeRate(currencyCode, rate);
    }

    public static double GetRate(string currencyCode)
    {
        return Rates.GetRate(currencyCode);
    }

    public static double GetCustomRate(string currencyCode)
    {
        return UserRates.GetRate(currencyCode);
    }

}

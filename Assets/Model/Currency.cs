using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency {

    public string CurrencyCode { get; set; }
    public static CurrencyConversionRate Rates { get; set; }
    public static CurrencyConversionRate MemoryRates { get; set; }
    public static CurrencyConversionRate UserRates { get; set; }

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



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour {

    public string CurrencyCode { get; set; }
    public CurrencyConversionRate Rates { get; set; }

    public Currency(string code)
    {
        CurrencyCode = code;
        Rates = new CurrencyConversionRate();
    }

    public double GetConversionRateFrom(string targetCurrencyCode)
    {
        return Rates.GetConversionFrom(this.CurrencyCode, targetCurrencyCode);
    }

    public decimal GetConversionFrom(string targetCurrencyCode, decimal price)
    {
        return  price * (decimal) Rates.GetConversionFrom(this.CurrencyCode, targetCurrencyCode);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

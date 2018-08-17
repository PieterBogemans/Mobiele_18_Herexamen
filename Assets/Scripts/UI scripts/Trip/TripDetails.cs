using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TripDetails : MonoBehaviour {

    public Text TripLocationName;
    public Text DefaultCurrency;

    public Transform OtherCurrencies;
    public CurrencyElement currencyElementPrefab;

    public Trip Trip;

	// Use this for initialization
	void Start ()
    {
		
	}

    public void Setup(Trip trip)
    {
        Trip = trip;
        TripLocationName.text = Trip.LocationName;
        DefaultCurrency.text = Trip.DefaultCurrency.CurrencyCode;
        UpdateCurrencies();
    }

    public void AddCurrency(Currency currency)
    {
        Trip.AddCurrencyToTrip(currency);
        UpdateCurrencies();
    }

    public void UpdateCurrencies()
    {
        foreach (Transform child in OtherCurrencies.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        
        foreach (Currency currency in Trip.Currencies)
        {
            CurrencyElement element = (CurrencyElement)Instantiate(currencyElementPrefab);
            element.PrimeButton(currency);
            element.transform.SetParent(OtherCurrencies, false);
        }
        
    }
	
}

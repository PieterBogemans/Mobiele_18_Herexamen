using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCurrency : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitCurrency()
    {
        TripDetails trip = GetComponent<TripDetails>();
        CurrencyRepository currencyRepo = GetComponent<CurrencyRepository>();
        CurrencyDropDown dropDown = GetComponent<CurrencyDropDown>();

        Currency currency = currencyRepo.GetCurrencyWithName(dropDown.selectedCurrency);

        trip.AddCurrency(currency);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyElement : MonoBehaviour {

    public Button currencyButton;

    public Currency Currency;

	// Use this for initialization
	void Start () {
        if (Currency != null) PrimeButton(Currency);
	}

    public void PrimeButton(Currency currency)
    {
        currencyButton.GetComponentInChildren<Text>().text = currency.CurrencyCode;
        currencyButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        /*
        GameObject tripPane = GameObject.Find("TripDetailsPane");
        tripPane.transform.SetAsLastSibling();
        GameObject scripts = GameObject.Find("Scripts");
        TripDetails details = scripts.GetComponent<TripDetails>();
        details.Setup(Trip);
        */
    }
}

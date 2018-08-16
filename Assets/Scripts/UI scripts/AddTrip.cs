using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTrip : MonoBehaviour {

    public GameObject TripLocationName;
    public GameObject CurrencyDropdown;
    private TripElementList tripElementList;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SubmitTrip()
    {
        string locationName = TripLocationName.GetComponent<Text>().text;
        TripRepository repo = GetComponent<TripRepository>();
        CurrencyRepository currencyRepo = GetComponent<CurrencyRepository>();
        CurrencyDropDown dropDown = GetComponent<CurrencyDropDown>();

        Currency currency = currencyRepo.GetCurrencyWithName(dropDown.selectedCurrency);

        repo.AddTrip(locationName, currency);

        tripElementList = GetComponent<TripElementList>();
        tripElementList.Prime();
    }


}

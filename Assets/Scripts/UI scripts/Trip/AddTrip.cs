using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTrip : MonoBehaviour {

    public InputField TripLocationName;
    public Text InvalidTripLocationName;
    public Button submitButton;
    private TripElementList tripElementList;

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitTrip()
    {
        string locationName = TripLocationName.text;
        TripRepository repo = GetComponent<TripRepository>();
        CurrencyRepository currencyRepo = GetComponent<CurrencyRepository>();
        CurrencyDropDown dropDown = GetComponent<CurrencyDropDown>();

        Currency currency = currencyRepo.GetCurrencyWithName(dropDown.selectedCurrency);

        repo.AddTrip(locationName, currency);

        tripElementList = GetComponent<TripElementList>();
        tripElementList.Prime();

        TripLocationName.text = "";
        InvalidTripLocationName.text = "";
        submitButton.interactable = false;
    }

    public void ValidateTrip(string name)
    {
        TripRepository repo = GetComponent<TripRepository>();
        Trip trip = repo.GetTrip(name);
        submitButton.interactable = trip == null && !string.IsNullOrEmpty(name);
        if (trip != null)
        {
            InvalidTripLocationName.text = "Location name already exists, if you're visiting the same location add identifier like: 'Paris 2018'";
        }
        else if (string.IsNullOrEmpty(name))
        {
            InvalidTripLocationName.text = "Location name cannot be empty";
        }
        else
        {
            InvalidTripLocationName.text = "";
        }
    }


}

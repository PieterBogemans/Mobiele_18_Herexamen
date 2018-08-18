using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TripElement : MonoBehaviour {

    public Button tripNameButton;

    public Trip Trip;

	// Use this for initialization
	void Start () {
        if (Trip != null) PrimeButton(Trip);
	}

    public void PrimeButton(Trip trip)
    {
        this.Trip = trip;

        tripNameButton.GetComponentInChildren<Text>().text = Trip.LocationName;
        tripNameButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        GameObject tripPane = GameObject.Find("TripDetailsPane");
        GameObject tripPanel = GameObject.Find("TripDetailsPanel");
        tripPane.transform.SetAsLastSibling();
        tripPanel.transform.SetAsLastSibling();
        GameObject scripts = GameObject.Find("Scripts");
        TripDetails details = scripts.GetComponent<TripDetails>();
        details.Setup(Trip);
    }
}

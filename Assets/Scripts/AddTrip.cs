using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTrip : MonoBehaviour {

    public GameObject TripLocationName;

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
        Currency currency = new Currency("USD");

        repo.AddTrip(locationName, currency);

    }


}

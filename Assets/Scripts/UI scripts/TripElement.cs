using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TripElement : MonoBehaviour {

    public Text tripName;

    public Trip Trip;

	// Use this for initialization
	void Start () {
        if (Trip != null) Prime(Trip);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Prime(Trip trip)
    {
        this.Trip = trip;

        tripName.text = Trip.LocationName;


    }
}

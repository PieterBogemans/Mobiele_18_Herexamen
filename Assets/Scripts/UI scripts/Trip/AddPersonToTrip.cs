using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPersonToTrip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitPerson()
    {
        PeopleDropdown dropdown = GetComponent<PeopleDropdown>();
        string name = dropdown.selectedPerson;

        PersonRepository repo = GetComponent<PersonRepository>();
        TripDetails trip = GetComponent<TripDetails>();
        trip.AddPerson(repo.GetPerson(name));

        PersonList personList = GetComponent<PersonList>();
        personList.Prime();
    }


}

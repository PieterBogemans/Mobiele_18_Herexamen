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

    public void ValideAddPersonToTrip()
    {
        PersonRepository repo = GetComponent<PersonRepository>();
        GameObject.Find("AddPersonToTripButton").GetComponent<Button>().interactable = repo.People.Count < 1;
        Text invalidPeopleCount = GameObject.Find("InvalidPeopleCount").GetComponent<Text>();
        if (repo.People.Count < 1)
        {
            invalidPeopleCount.text = "No people in the application, please add people in the people tab above";
        } else
        {
            invalidPeopleCount.text = "";
        }
    }

}

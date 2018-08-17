using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleDropdown : MonoBehaviour {

    public Dropdown AddPersonToTrip;
    public Dropdown AddPersonWhoPaidToExpense;
    List<string> dropdownOptions = new List<string>();
    public string selectedPerson;

    // Use this for initialization
    public void Dropdown_IndexChanged(int index)
    {
        selectedPerson = dropdownOptions[index];
    }

    void Start ()
    {

    }
    public void PrimeAddPerson()
    {
        PersonRepository repo = GetComponent<PersonRepository>();
        TripDetails details = GetComponent<TripDetails>();
        dropdownOptions = new List<string>();
        AddPersonToTrip.options.Clear();

        if (repo.People != null)
        {
            foreach (KeyValuePair<int, Person> person in repo.People)
            {
                bool personNotYetInTrip = true;
                foreach (KeyValuePair<int, Person> TripPerson in details.Trip.PeopleOnTrip)
                {
                    if (personNotYetInTrip) { personNotYetInTrip = TripPerson.Value.Id != person.Value.Id; }
                }
                if (personNotYetInTrip) { dropdownOptions.Add(person.Value.PersonName); }
            }
            AddPersonToTrip.AddOptions(dropdownOptions);
            if (dropdownOptions.Count != 0) selectedPerson = dropdownOptions[0];
        }
    }

    public void PrimeAddExpense()
    {
        TripDetails details = GetComponent<TripDetails>();
        dropdownOptions = new List<string>();
        AddPersonWhoPaidToExpense.options.Clear();

        foreach (KeyValuePair<int, Person> person in details.Trip.PeopleOnTrip)
        {
            dropdownOptions.Add(person.Value.PersonName); 
        }
        AddPersonWhoPaidToExpense.AddOptions(dropdownOptions);
        if (dropdownOptions.Count != 0) selectedPerson = dropdownOptions[0];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddExpense : MonoBehaviour {

    public GameObject ExpenseNameText;

	// Use this for initialization
	void Start () {
		
	}

    public void SubmitExpense()
    {
        string expenseName = ExpenseNameText.GetComponent<Text>().text;
        TripDetails details = GetComponent<TripDetails>();

        PeopleDropdown dropdown = GetComponent<PeopleDropdown>();
        string personName = dropdown.selectedPerson;

        PersonRepository repo = GetComponent<PersonRepository>();
        Person person = repo.GetPerson(personName);

        details.Trip.AddExpenseToTrip(expenseName, person);

        ExpenseElementList expenseList = GetComponent<ExpenseElementList>();
        expenseList.Prime();

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddExpense : MonoBehaviour {

    public InputField ExpenseNameText;
    public Button submitButton;
    public Text invalidExpenseName;

    // Use this for initialization
    void Start () {
		
	}

    public void SubmitExpense()
    {
        string expenseName = ExpenseNameText.text;
        TripDetails details = GetComponent<TripDetails>();

        PeopleDropdown dropdown = GetComponent<PeopleDropdown>();
        string personName = dropdown.selectedPerson;

        PersonRepository repo = GetComponent<PersonRepository>();
        Person person = repo.GetPerson(personName);

        CurrencyDropDown currencyDropDown = GetComponent<CurrencyDropDown>();
        string currencyCode = currencyDropDown.selectedCurrency;

        CurrencyRepository currencyRepo = GetComponent<CurrencyRepository>();
        Currency currency = currencyRepo.GetCurrencyWithName(currencyCode);

        details.Trip.AddExpenseToTrip(expenseName, person, currency);

        ExpenseElementList expenseList = GetComponent<ExpenseElementList>();
        expenseList.Prime();
    }

    public void ValidateExpenseName(string name)
    {
        TripDetails details = GetComponent<TripDetails>();
        submitButton.interactable = !string.IsNullOrEmpty(name) && !(details.Trip.PeopleOnTrip.Count < 2);

        Text invalidPeople = GameObject.Find("InvalidWhoPaidName").GetComponent<UnityEngine.UI.Text>();

        if (string.IsNullOrEmpty(name)) { invalidExpenseName.text = "Name cannot be empty"; }
        else { invalidExpenseName.text = ""; }
        if (details.Trip.PeopleOnTrip.Count < 2) { invalidPeople.text = "Expense need at least two people, please add more people to the trip"; }
        else { invalidPeople.text = ""; }
    }

    public void ValidateExpenseName()
    {
        InputField ExpenseName = GameObject.Find("ExpenseNameAnswer").GetComponent<InputField>();
        TripDetails details = GetComponent<TripDetails>();
        submitButton.interactable = !string.IsNullOrEmpty(ExpenseName.text) && !(details.Trip.PeopleOnTrip.Count < 2);

        Text invalidPeople = GameObject.Find("InvalidWhoPaidName").GetComponent<UnityEngine.UI.Text>();

        if (string.IsNullOrEmpty(ExpenseName.text)) { invalidExpenseName.text = "Name cannot be empty"; }
        else { invalidExpenseName.text = ""; }
        if (details.Trip.PeopleOnTrip.Count < 2) { invalidPeople.text = "Expense need at least two people, please add more people to the trip"; }
        else { invalidPeople.text = ""; }
    }


}

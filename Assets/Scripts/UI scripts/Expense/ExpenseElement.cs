using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpenseElement : MonoBehaviour {

    public Button ExpenseButton;
    public Expense Expense;

	// Use this for initialization
	void Start () {
        if (Expense != null) PrimeButton(Expense);
	}

    public void PrimeButton(Expense expense)
    {
        this.Expense = expense;

        ExpenseButton.GetComponentInChildren<Text>().text = Expense.ExpenseName;
        ExpenseButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        /*
        TripPane.transform.SetAsLastSibling();
        GameObject Scripts = GameObject.Find("Scripts");
        PersonDetails details = Scripts.GetComponent<PersonDetails>();
        details.Setup(Person);
        */
    }
}

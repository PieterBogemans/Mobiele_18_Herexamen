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
        GameObject expenseDetails = GameObject.Find("ExpenseDetails");
        expenseDetails.transform.SetAsLastSibling();
        GameObject expenseDetailsPanel = GameObject.Find("ExpenseDetailsPanel");
        expenseDetailsPanel.transform.SetAsLastSibling();

        GameObject scripts = GameObject.Find("Scripts");
        ExpenseDetails details = scripts.GetComponent<ExpenseDetails>();
        details.Setup(Expense);
    }
}

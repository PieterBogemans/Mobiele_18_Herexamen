using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpenseDetails : MonoBehaviour {

    public Text ExpenseName;
    public Text ExpenseCurrency;

    public Transform ItemsInExpense;
    public ItemElement ItemElementPrefab;

    public Expense Expense;

    public void Setup(Expense expense)
    {
        Expense = expense;
        ExpenseName.text = Expense.ExpenseName;
        ExpenseCurrency.text = Expense.Currency.CurrencyCode;
        UpdateItems();
    }

    public void AddItem(string itemName, decimal price, Person whoConsumedItem)
    {
        Expense.AddItem(itemName, price, whoConsumedItem);
        UpdateItems();
    }

    public void UpdateItems()
    {
        foreach (Transform child in ItemsInExpense.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        if (Expense != null)
        {
            foreach (ItemToPay item in Expense.ItemsToPay)
            {
                ItemElement element = (ItemElement)Instantiate(ItemElementPrefab);
                element.PrimeButton(item);
                element.transform.SetParent(ItemsInExpense, false);
            }
        }
    }
}

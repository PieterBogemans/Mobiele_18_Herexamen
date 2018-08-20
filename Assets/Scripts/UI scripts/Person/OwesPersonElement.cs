using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwesPersonElement : MonoBehaviour {

    public Button PersonButton;
    public Person MainPerson;
    public Person ListPerson;
    public Text AmountPaid;
    public Text AmountDue;
    public Text StillNeedsToRecieve;
    public GameObject RecieveBackground;

    public void Prime(Person mainPerson, Person listPerson, Currency currency)
    {
        this.MainPerson = mainPerson;
        this.ListPerson = listPerson;

        PersonButton.GetComponentInChildren<Text>().text = listPerson.PersonName;
        PersonButton.onClick.AddListener(AddButtonOnClick);
        decimal paid = Math.Round(mainPerson.GetAmountDueInCurrency(listPerson, currency), 2);
        decimal due = Math.Round(mainPerson.GetAmountPaidInCurrency(listPerson, currency), 2);
        AmountPaid.text = paid.ToString();
        AmountDue.text = due.ToString();
        decimal difference = paid - due;
        if (paid - due > 0)
        {
            StillNeedsToRecieve.text = (paid - due).ToString();
            RecieveBackground.GetComponent<Image>().color = Color.green;
        } else
        {

            StillNeedsToRecieve.text = (due - paid).ToString();
            RecieveBackground.GetComponent<Image>().color = Color.red;
        }
    } 

    public void AddButtonOnClick()
    {
        GameObject addTransaction = GameObject.Find("AddTransactionPane");
        addTransaction.transform.SetAsLastSibling();
        PersonDetails details = GameObject.Find("Scripts").GetComponent<PersonDetails>();
        GameObject.Find("TransactionCurrencyTag").GetComponent<Text>().text = details.Currency.CurrencyCode;
        details.MainPerson = MainPerson;
        details.ListPerson = ListPerson;
        GameObject.Find("Scripts").GetComponent<TransactionList>().Prime();

    }
}
